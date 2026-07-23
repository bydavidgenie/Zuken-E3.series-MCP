using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ZukenE3Mcp.API
{
    /// <summary>
    /// STA (Single Threaded Apartment) Thread Executor.
    /// Zuken E3 COM Automation requires all API calls to run on a single-threaded apartment (STA) thread.
    /// This executor manages a dedicated background STA thread and schedules tasks sequentially.
    /// </summary>
    public class StaThreadExecutor : IDisposable
    {
        public static StaThreadExecutor Instance { get; } = new StaThreadExecutor();

        private readonly BlockingCollection<Action> _queue = new();
        private readonly Thread _thread;
        private bool _disposed;

        public StaThreadExecutor()
        {
            _thread = new Thread(Run)
            {
                IsBackground = true,
                Name = "ZukenE3McpSTAThread"
            };
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void Run()
        {
            foreach (var action in _queue.GetConsumingEnumerable())
            {
                try
                {
                    action();
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"STA Thread Action Execution Error: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Executes a synchronous action on the STA thread.
        /// </summary>
        public Task ExecuteAsync(Action action)
        {
            var tcs = new TaskCompletionSource();
            _queue.Add(() =>
            {
                try
                {
                    action();
                    tcs.SetResult();
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            });
            return tcs.Task;
        }

        /// <summary>
        /// Executes a function that returns a value on the STA thread.
        /// </summary>
        public Task<T> ExecuteAsync<T>(Func<T> func)
        {
            var tcs = new TaskCompletionSource<T>();
            _queue.Add(() =>
            {
                try
                {
                    var result = func();
                    tcs.SetResult(result);
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            });
            return tcs.Task;
        }

        /// <summary>
        /// Executes an action synchronously on the STA thread, blocking until completion.
        /// </summary>
        public void Execute(Action action)
        {
            ExecuteAsync(action).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Executes a function synchronously on the STA thread returning a value, blocking until completion.
        /// </summary>
        public T Execute<T>(Func<T> func)
        {
            return ExecuteAsync(func).GetAwaiter().GetResult();
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _queue.CompleteAdding();
                _disposed = true;
            }
        }
    }
}

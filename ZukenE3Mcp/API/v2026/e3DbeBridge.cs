using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3DbeBridge : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeBridge _raw;
        private bool _disposed;

        public e3DbeBridge(Zuken.E3.Interop.e3DbeBridge raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeBridge RawObject => _raw;

        public void BringToForeground()
        {
            StaThreadExecutor.Instance.Execute(() => _raw.BringToForeground());
        }

        public void Edit(int mode, int what, string entry, string version)
        {
            StaThreadExecutor.Instance.Execute(() => _raw.Edit(mode, what, entry, version));
        }

        public void EditWithPreconditions(int mode, int what, string entry, string version, ref object preconditions)
        {
            object local_preconditions = preconditions;
            StaThreadExecutor.Instance.Execute(() => _raw.EditWithPreconditions(mode, what, entry, version, ref local_preconditions));
            preconditions = local_preconditions;
        }

        public void New(int mode, int what, string baseEntry, string baseVersion, string name, string version)
        {
            StaThreadExecutor.Instance.Execute(() => _raw.New(mode, what, baseEntry, baseVersion, name, version));
        }

        public void NewWithPreconditions(int mode, int what, string baseEntry, string baseVersion, string name, string version, ref object preconditions)
        {
            object local_preconditions = preconditions;
            StaThreadExecutor.Instance.Execute(() => _raw.NewWithPreconditions(mode, what, baseEntry, baseVersion, name, version, ref local_preconditions));
            preconditions = local_preconditions;
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                if (_raw != null && Marshal.IsComObject(_raw))
                {
                    Marshal.ReleaseComObject(_raw);
                }
                _disposed = true;
            }
        }
    }
}

using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3InfoApplication : IDisposable
    {
        private readonly Zuken.E3.Interop.e3InfoApplication _raw;
        private bool _disposed;

        public e3InfoApplication(Zuken.E3.Interop.e3InfoApplication raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3InfoApplication RawObject => _raw;

        public string GetWindowPos(double x, double y, string text)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetWindowPos(x, y, text));
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

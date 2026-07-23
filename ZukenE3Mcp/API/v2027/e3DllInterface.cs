using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3DllInterface : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DllInterface _raw;
        private bool _disposed;

        public e3DllInterface(Zuken.E3.Interop.e3DllInterface raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DllInterface RawObject => _raw;

        public int Call(string method, string item1, string item2, string item3, string item4, string item5)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Call(method, item1, item2, item3, item4, item5));
        }

        public int Load(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Load(name));
        }

        public int Unload()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Unload());
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

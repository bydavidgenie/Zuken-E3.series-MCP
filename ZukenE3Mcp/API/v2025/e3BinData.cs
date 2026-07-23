using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3BinData : IDisposable
    {
        private readonly Zuken.E3.Interop.e3BinData _raw;
        private bool _disposed;

        public e3BinData(Zuken.E3.Interop.e3BinData raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3BinData RawObject => _raw;

        public int GetData(string name, ref object data, int maxlen)
        {
            object local_data = data;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetData(name, ref local_data, maxlen));
            data = local_data;
            return retVal;
        }

        public int SetData(string name, ref object data, int maxlen)
        {
            object local_data = data;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetData(name, ref local_data, maxlen));
            data = local_data;
            return retVal;
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

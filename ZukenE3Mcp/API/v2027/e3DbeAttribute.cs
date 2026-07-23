using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3DbeAttribute : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeAttribute _raw;
        private bool _disposed;

        public e3DbeAttribute(Zuken.E3.Interop.e3DbeAttribute raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeAttribute RawObject => _raw;

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public string GetFormattedValue()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFormattedValue());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetInternalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalName());
        }

        public string GetInternalValue()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalValue());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public string GetValue()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetValue());
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetValue(string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetValue(value));
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

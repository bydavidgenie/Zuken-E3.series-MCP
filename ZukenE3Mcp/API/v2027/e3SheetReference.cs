using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3SheetReference : IDisposable
    {
        private readonly Zuken.E3.Interop.e3SheetReference _raw;
        private bool _disposed;

        public e3SheetReference(Zuken.E3.Interop.e3SheetReference raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3SheetReference RawObject => _raw;

        public int GetDestinationSymbolIds(out object ids, int flags)
        {
            object local_ids = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDestinationSymbolIds(out local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetSourceSymbolIds(out object ids, int flags)
        {
            object local_ids = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSourceSymbolIds(out local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
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

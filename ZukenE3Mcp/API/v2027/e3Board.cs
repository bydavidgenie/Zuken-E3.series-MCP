using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3Board : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Board _raw;
        private bool _disposed;

        public e3Board(Zuken.E3.Interop.e3Board raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Board RawObject => _raw;

        public int Create(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name));
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetLayerIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLayerIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetOutlineId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOutlineId());
        }

        public int GetSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSheetIds(ref local_ids));
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

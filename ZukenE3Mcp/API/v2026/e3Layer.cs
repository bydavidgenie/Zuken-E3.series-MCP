using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Layer : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Layer _raw;
        private bool _disposed;

        public e3Layer(Zuken.E3.Interop.e3Layer raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Layer RawObject => _raw;

        public int Create(string name, int type, int copper, int layer_id, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name, type, copper, layer_id, before));
        }

        public int GetBoardLayerIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBoardLayerIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int IsGlobalLayer()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsGlobalLayer());
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

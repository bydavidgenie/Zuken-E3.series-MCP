using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3DbeComponent : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeComponent _raw;
        private bool _disposed;

        public e3DbeComponent(Zuken.E3.Interop.e3DbeComponent raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeComponent RawObject => _raw;

        public int AddAttributeValue(string name, string value, int end)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value, end));
        }

        public int GetAttributeIds(ref object ids, int end, string attnam)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeIds(ref local_ids, end, attnam));
            ids = local_ids;
            return retVal;
        }

        public int GetComponentType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentType());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetModelName(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetModelName(flags));
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetSubType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSubType());
        }

        public string GetVersion()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVersion());
        }

        public int Remove(int save_changes)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Remove(save_changes));
        }

        public int Save()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Save());
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetModelName(string ModelName, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetModelName(ModelName, flags));
        }

        public int SetSubType(int subtype)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSubType(subtype));
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

using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3State : IDisposable
    {
        private readonly Zuken.E3.Interop.e3State _raw;
        private bool _disposed;

        public e3State(Zuken.E3.Interop.e3State raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3State RawObject => _raw;

        public int GetAttributeIds(out object ids, string name)
        {
            object local_ids = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeIds(out local_ids, name));
            ids = local_ids;
            return retVal;
        }

        public string GetAttributeValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeValue(name));
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public string GetGUID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGUID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetOwnerId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOwnerId());
        }

        public int GetOwnerIds(out object ids)
        {
            object local_ids = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOwnerIds(out local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOwnerType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOwnerType());
        }

        public int GetStateType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetStateType());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetGUID(string guid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGUID(guid));
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

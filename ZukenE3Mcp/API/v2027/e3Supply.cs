using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3Supply : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Supply _raw;
        private bool _disposed;

        public e3Supply(Zuken.E3.Interop.e3Supply raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Supply RawObject => _raw;

        public int Create(int devid, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(devid, name));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int GetBlockId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockId());
        }

        public int GetComponentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetComponentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetDevCompIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDevCompIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public string GetOwnerName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOwnerName());
        }

        public int GetPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSignalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSignalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetSignalTypeName(int which)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalTypeName(which));
        }

        public int Search(int devid, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(devid, name));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
        }

        public int SetSignalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetSignalIds(ref local_ids));
            ids = local_ids;
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

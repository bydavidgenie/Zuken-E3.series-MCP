using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3Clipboard : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Clipboard _raw;
        private bool _disposed;

        public e3Clipboard(Zuken.E3.Interop.e3Clipboard raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Clipboard RawObject => _raw;

        public int CommitToProject(int flags, int viewnumber)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CommitToProject(flags, viewnumber));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteForced()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteForced());
        }

        public int GetAnyIds(int flags, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAnyIds(flags, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCollidingIds(int flags, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCollidingIds(flags, ref local_ids));
            ids = local_ids;
            return retVal;
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

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public string SetGUID(string guid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGUID(guid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
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

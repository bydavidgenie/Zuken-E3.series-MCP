using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3Module : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Module _raw;
        private bool _disposed;

        public e3Module(Zuken.E3.Interop.e3Module raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Module RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int GetAttributeCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeCount());
        }

        public int GetAttributeIds(ref object ids, string attnam)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeIds(ref local_ids, attnam));
            ids = local_ids;
            return retVal;
        }

        public string GetAttributeValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeValue(name));
        }

        public string GetFileName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFileName());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLevel());
        }

        public int GetModuleIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetModuleIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetParentModuleId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParentModuleId());
        }

        public int GetParentSheetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParentSheetId());
        }

        public int GetPortCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPortCount());
        }

        public int GetPortIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPortIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetTypeName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTypeName());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int IsTypeLoadable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsTypeLoadable());
        }

        public int Search(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(name));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
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

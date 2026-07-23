using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3Attribute : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Attribute _raw;
        private bool _disposed;

        public e3Attribute(Zuken.E3.Interop.e3Attribute raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Attribute RawObject => _raw;

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DisplayAttribute(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayAttribute(id));
        }

        public int DisplayValueAt(int sheetid, double x, double y, int bindid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayValueAt(sheetid, x, y, bindid));
        }

        public string FormatValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FormatValue(name, value));
        }

        public string GetFormattedValue()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFormattedValue());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
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

        public int GetLockChangeable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLockChangeable());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetOwnerId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOwnerId());
        }

        public int GetTextCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTextCount());
        }

        public int GetTextIds(ref object ids, int txttyp, string search_string)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTextIds(ref local_ids, txttyp, search_string));
            ids = local_ids;
            return retVal;
        }

        public string GetValue()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetValue());
        }

        public int IsLockChangeable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLockChangeable());
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetLockChangeable(int lockchangeable)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLockChangeable(lockchangeable));
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

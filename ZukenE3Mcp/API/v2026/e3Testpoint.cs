using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Testpoint : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Testpoint _raw;
        private bool _disposed;

        public e3Testpoint(Zuken.E3.Interop.e3Testpoint raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Testpoint RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int Create(int ani)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(ani));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DisplayAttributeValueAt(string name, int sheetid, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayAttributeValueAt(name, sheetid, x, y));
        }

        public int Dump()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Dump());
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

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int Highlight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Highlight());
        }

        public int Search(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(name));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetAttributeVisibility(string name, int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeVisibility(name, onoff));
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

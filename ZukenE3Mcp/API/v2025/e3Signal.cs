using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3Signal : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Signal _raw;
        private bool _disposed;

        public e3Signal(Zuken.E3.Interop.e3Signal raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Signal RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int AddDefaultWire(IntPtr wiregroup, IntPtr wirename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddDefaultWire(wiregroup, wirename));
        }

        public int AddDefaultWireEx(string wiregroup, string wirename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddDefaultWireEx(wiregroup, wirename));
        }

        public int Create(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name));
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DeleteDefaultWire(IntPtr wiregroup, IntPtr wirename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteDefaultWire(wiregroup, wirename));
        }

        public int DeleteDefaultWireEx(string wiregroup, string wirename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteDefaultWireEx(wiregroup, wirename));
        }

        public int DisplayaAttributeValueAt(string name, int sheetid, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayaAttributeValueAt(name, sheetid, x, y));
        }

        public int DisplayAttributeValueAt(string name, int sheetid, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayAttributeValueAt(name, sheetid, x, y));
        }

        public int FindPanelPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FindPanelPath());
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

        public int GetCoreCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCoreCount());
        }

        public int GetCoreIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCoreIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetDefaultWires(ref object wiregroups, ref object wirenames)
        {
            object local_wiregroups = wiregroups;
            object local_wirenames = wirenames;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDefaultWires(ref local_wiregroups, ref local_wirenames));
            wiregroups = local_wiregroups;
            wirenames = local_wirenames;
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

        public string GetNameFormat()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNameFormat());
        }

        public int GetNetSegmentCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNetSegmentCount());
        }

        public int GetNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetPinCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinCount());
        }

        public int GetPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetRecalcFormattedName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRecalcFormattedName());
        }

        public int GetSignalClassId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalClassId());
        }

        public string GetTranslatedName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTranslatedName());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int Highlight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Highlight());
        }

        public int HighlightCoreLogicLinesOfSignal()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HighlightCoreLogicLinesOfSignal());
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

        public int SetDefaultWires(ref object wiregroups, ref object wirenames)
        {
            object local_wiregroups = wiregroups;
            object local_wirenames = wirenames;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetDefaultWires(ref local_wiregroups, ref local_wirenames));
            wiregroups = local_wiregroups;
            wirenames = local_wirenames;
            return retVal;
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

        public int SetNameFormat(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetNameFormat(name));
        }

        public int SetRecalcFormattedName(int recalculate)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRecalcFormattedName(recalculate));
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

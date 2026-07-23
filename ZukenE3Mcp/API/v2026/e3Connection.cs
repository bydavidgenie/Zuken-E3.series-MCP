using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Connection : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Connection _raw;
        private bool _disposed;

        public e3Connection(Zuken.E3.Interop.e3Connection raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Connection RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int Create(int shti, int pnts, ref object x, ref object y, ref object PointTypArr)
        {
            object local_x = x;
            object local_y = y;
            object local_PointTypArr = PointTypArr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Create(shti, pnts, ref local_x, ref local_y, ref local_PointTypArr));
            x = local_x;
            y = local_y;
            PointTypArr = local_PointTypArr;
            return retVal;
        }

        public int CreateBus(int shti, int pnts, ref object x, ref object y)
        {
            object local_x = x;
            object local_y = y;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateBus(shti, pnts, ref local_x, ref local_y));
            x = local_x;
            y = local_y;
            return retVal;
        }

        public int CreateConnection(int flags, int shti, int pnts, ref object x, ref object y, ref object connections, ref object PointTypArr)
        {
            object local_x = x;
            object local_y = y;
            object local_connections = connections;
            object local_PointTypArr = PointTypArr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateConnection(flags, shti, pnts, ref local_x, ref local_y, ref local_connections, ref local_PointTypArr));
            x = local_x;
            y = local_y;
            connections = local_connections;
            PointTypArr = local_PointTypArr;
            return retVal;
        }

        public int CreateConnectionBetweenPoints(int shti, double x1, double y1, double x2, double y2, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateConnectionBetweenPoints(shti, x1, y1, x2, y2, flags));
        }

        public object CreateOnFormboard(int shti, int pnts, ref object x, ref object y, ref object PointTypArr)
        {
            object local_x = x;
            object local_y = y;
            object local_PointTypArr = PointTypArr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateOnFormboard(shti, pnts, ref local_x, ref local_y, ref local_PointTypArr));
            x = local_x;
            y = local_y;
            PointTypArr = local_PointTypArr;
            return retVal;
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DisplayAttributeValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayAttributeValue(name));
        }

        public int DisplayAttributeValueAt(string name, int sheetid, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayAttributeValueAt(name, sheetid, x, y));
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

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetNetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNetId());
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

        public int GetPinGroupCount(int num)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinGroupCount(num));
        }

        public int GetPinGroupIds(int num, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinGroupIds(num, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetPinGroupsCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinGroupsCount());
        }

        public int GetPinGroupsIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinGroupsIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetReferenceSymbolCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetReferenceSymbolCount());
        }

        public int GetReferenceSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetReferenceSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetSignalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalName());
        }

        public string GetTranslatedSignalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTranslatedSignalName());
        }

        public int GetViewNumber()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetViewNumber());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int Highlight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Highlight());
        }

        public int IsValid()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsValid());
        }

        public int IsView()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsView());
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetAttributeVisibility(string name, int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeVisibility(name, onoff));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetSignalName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSignalName(name));
        }

        public int SetSignalNameOnLocalNet(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSignalNameOnLocalNet(name));
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

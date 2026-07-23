using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3NetSegment : IDisposable
    {
        private readonly Zuken.E3.Interop.e3NetSegment _raw;
        private bool _disposed;

        public e3NetSegment(Zuken.E3.Interop.e3NetSegment raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3NetSegment RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int AdjustSchemaLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AdjustSchemaLength());
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
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

        public int GetAssignedOptionExpressions(ref object expressions, int Term)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAssignedOptionExpressions(ref local_expressions, Term));
            expressions = local_expressions;
            return retVal;
        }

        public int GetAssignedOptionExpressionsEx(ref object expressions, int Term)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAssignedOptionExpressionsEx(ref local_expressions, Term));
            expressions = local_expressions;
            return retVal;
        }

        public int GetAssignedOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAssignedOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
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

        public int GetBundleSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBundleSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetBusName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBusName());
        }

        public int GetConnectedSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectedSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetConnectLineIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectLineIds(ref local_ids));
            ids = local_ids;
            return retVal;
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

        public int GetEffectiveDirection(ref object fromID, ref object toID)
        {
            object local_fromID = fromID;
            object local_toID = toID;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetEffectiveDirection(ref local_fromID, ref local_toID));
            fromID = local_fromID;
            toID = local_toID;
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

        public double GetLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLength());
        }

        public int GetLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLevel());
        }

        public int GetLineColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineColour());
        }

        public int GetLineSegments(ref object shtId, ref object xarr, ref object yarr, ref object PointTypArr)
        {
            object local_shtId = shtId;
            object local_xarr = xarr;
            object local_yarr = yarr;
            object local_PointTypArr = PointTypArr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLineSegments(ref local_shtId, ref local_xarr, ref local_yarr, ref local_PointTypArr));
            shtId = local_shtId;
            xarr = local_xarr;
            yarr = local_yarr;
            PointTypArr = local_PointTypArr;
            return retVal;
        }

        public int GetLineStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineStyle());
        }

        public double GetLineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineWidth());
        }

        public double GetManufacturingLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetManufacturingLength());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetNetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNetId());
        }

        public int GetNodeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNodeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public double GetOuterDiameter()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOuterDiameter());
        }

        public double GetRotation(int anchorid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRotation(anchorid));
        }

        public double GetSchemaLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSchemaLength());
        }

        public int GetSignalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSignalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetSignalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalName());
        }

        public int GetSymbolCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolCount());
        }

        public int GetSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetTranslatedSignalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTranslatedSignalName());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int Highlight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Highlight());
        }

        public int IsBus()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBus());
        }

        public int IsBusbar()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBusbar());
        }

        public int IsOffline()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsOffline());
        }

        public int IsPanelPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPanelPath());
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

        public int SetBusName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBusName(name));
        }

        public int SetEffectiveDirection(int toID)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetEffectiveDirection(toID));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetIgnoreForCablingTable(int set)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetIgnoreForCablingTable(set));
        }

        public double SetLength(double newlen)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLength(newlen));
        }

        public int SetLevel(int level)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLevel(level));
        }

        public int SetLineColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineColour(newcol));
        }

        public int SetLineLevel(int newlev)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineLevel(newlev));
        }

        public int SetLineStyle(int newstl)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineStyle(newstl));
        }

        public int SetLineWidth(double newwid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineWidth(newwid));
        }

        public double SetManufacturingLength(double newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetManufacturingLength(newval));
        }

        public int SetOptionExpressions(ref object expressions)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetOptionExpressions(ref local_expressions));
            expressions = local_expressions;
            return retVal;
        }

        public double SetRotation(int anchorid, double newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRotation(anchorid, newval));
        }

        public double SetSchemaLength(double newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSchemaLength(newval));
        }

        public int SetSignalName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSignalName(name));
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

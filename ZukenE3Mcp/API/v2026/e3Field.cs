using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Field : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Field _raw;
        private bool _disposed;

        public e3Field(Zuken.E3.Interop.e3Field raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Field RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int GetAllInsideFieldIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllInsideFieldIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetArea(ref object xmin, ref object ymin, ref object xmax, ref object ymax)
        {
            object local_xmin = xmin;
            object local_ymin = ymin;
            object local_xmax = xmax;
            object local_ymax = ymax;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetArea(ref local_xmin, ref local_ymin, ref local_xmax, ref local_ymax));
            xmin = local_xmin;
            ymin = local_ymin;
            xmax = local_xmax;
            ymax = local_ymax;
            return retVal;
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

        public int GetCrossingFieldIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCrossingFieldIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCrossingNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCrossingNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCrossingPanelConnectionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCrossingPanelConnectionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetDeviceAssignment()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDeviceAssignment());
        }

        public string GetDeviceLocation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDeviceLocation());
        }

        public string GetDeviceName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDeviceName());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetGraphId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphId());
        }

        public string GetGUID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGUID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetInsideFieldIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsideFieldIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetInsideGraphIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsideGraphIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetInsideNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsideNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetInsidePanelConnectionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsidePanelConnectionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetInsideSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsideSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetInsideTextIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsideTextIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetInterruptBorder()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInterruptBorder());
        }

        public double GetInterruptBorderGap()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInterruptBorderGap());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetParentFieldId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParentFieldId());
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid, ref object column_value, ref object row_value)
        {
            object local_x = x;
            object local_y = y;
            object local_grid = grid;
            object local_column_value = column_value;
            object local_row_value = row_value;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSchemaLocation(ref local_x, ref local_y, ref local_grid, ref local_column_value, ref local_row_value));
            x = local_x;
            y = local_y;
            grid = local_grid;
            column_value = local_column_value;
            row_value = local_row_value;
            return retVal;
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

        public string GetType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetType());
        }

        public string GetTypeName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTypeName());
        }

        public string GetVersion()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVersion());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int Jump()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Jump());
        }

        public int Place(int shti, double x1, double y1, double x2, double y2, int moveall)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Place(shti, x1, y1, x2, y2, moveall));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetCompleteName(string newdev, string newass, string newloc, int onlygiven)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCompleteName(newdev, newass, newloc, onlygiven));
        }

        public int SetDeviceAssignment(string newass)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceAssignment(newass));
        }

        public int SetDeviceLocation(string newloc)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceLocation(newloc));
        }

        public int SetDeviceName(string newdev)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceName(newdev));
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

        public int SetInterruptBorder(int interrupt)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetInterruptBorder(interrupt));
        }

        public double SetInterruptBorderGap(double gap)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetInterruptBorderGap(gap));
        }

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
        }

        public int SetOptionExpressions(ref object expressions)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetOptionExpressions(ref local_expressions));
            expressions = local_expressions;
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

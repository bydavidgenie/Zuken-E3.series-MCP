using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3Text : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Text _raw;
        private bool _disposed;

        public e3Text(Zuken.E3.Interop.e3Text raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Text RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int CalculateBoxAt(int shti, string text, double x, double y, double rotation, double height, int mode, int style, string fontname, int just, int balloon, ref object bx, ref object by)
        {
            object local_bx = bx;
            object local_by = by;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CalculateBoxAt(shti, text, x, y, rotation, height, mode, style, fontname, just, balloon, ref local_bx, ref local_by));
            bx = local_bx;
            by = local_by;
            return retVal;
        }

        public int CalculateBoxHeight(double width, string text, string fontname, double fontSize, int fontStyle, int wordBreak, out object recHeight, out object recWidth, out object lines)
        {
            object local_recHeight = default;
            object local_recWidth = default;
            object local_lines = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CalculateBoxHeight(width, text, fontname, fontSize, fontStyle, wordBreak, out local_recHeight, out local_recWidth, out local_lines));
            recHeight = local_recHeight;
            recWidth = local_recWidth;
            lines = local_lines;
            return retVal;
        }

        public int CalculateBoxHeightEx(double width, string text, string fontname, double fontSize, int fontMode, int fontStyle, out object recHeight, out object recWidth, out object lines)
        {
            object local_recHeight = default;
            object local_recWidth = default;
            object local_lines = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CalculateBoxHeightEx(width, text, fontname, fontSize, fontMode, fontStyle, out local_recHeight, out local_recWidth, out local_lines));
            recHeight = local_recHeight;
            recWidth = local_recWidth;
            lines = local_lines;
            return retVal;
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DeleteBox()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteBox());
        }

        public int GetAlignment()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAlignment());
        }

        public int GetAllowedLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAllowedLength());
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

        public int GetBallooning()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBallooning());
        }

        public int GetBox(ref object xsize, ref object ysize)
        {
            object local_xsize = xsize;
            object local_ysize = ysize;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBox(ref local_xsize, ref local_ysize));
            xsize = local_xsize;
            ysize = local_ysize;
            return retVal;
        }

        public int GetColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetColour());
        }

        public string GetFontName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFontName());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public double GetHeight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHeight());
        }

        public string GetHyperlinkAddress()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHyperlinkAddress());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetInternalText()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalText());
        }

        public int GetLanguageId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLanguageId());
        }

        public int GetLeftJustifiedSchemaLocation(ref object x, ref object y, ref object grid)
        {
            object local_x = x;
            object local_y = y;
            object local_grid = grid;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLeftJustifiedSchemaLocation(ref local_x, ref local_y, ref local_grid));
            x = local_x;
            y = local_y;
            grid = local_grid;
            return retVal;
        }

        public int GetLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLevel());
        }

        public int GetLinearMeasureWithoutUnit()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLinearMeasureWithoutUnit());
        }

        public int GetLocking()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocking());
        }

        public int GetMode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMode());
        }

        public int GetPictogram()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPictogram());
        }

        public int GetRightJustifiedSchemaLocation(ref object x, ref object y, ref object grid)
        {
            object local_x = x;
            object local_y = y;
            object local_grid = grid;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetRightJustifiedSchemaLocation(ref local_x, ref local_y, ref local_grid));
            x = local_x;
            y = local_y;
            grid = local_grid;
            return retVal;
        }

        public double GetRotation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRotation());
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

        public int GetSingleLine()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSingleLine());
        }

        public int GetStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetStyle());
        }

        public string GetText()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetText());
        }

        public int GetTextExtent(ref object xarr, ref object yarr)
        {
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTextExtent(ref local_xarr, ref local_yarr));
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public int GetTextExtentSingleLine(ref object nlines, ref object xarr, ref object yarr)
        {
            object local_nlines = nlines;
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTextExtentSingleLine(ref local_nlines, ref local_xarr, ref local_yarr));
            nlines = local_nlines;
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public int GetType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetType());
        }

        public int GetTypeId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTypeId());
        }

        public int GetVisibility()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVisibility());
        }

        public double GetWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetWidth());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int IsOffline()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsOffline());
        }

        public int IsRedlined()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsRedlined());
        }

        public int SendToBackground()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SendToBackground());
        }

        public int SendToForeground()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SendToForeground());
        }

        public int SetAlignment(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAlignment(newval));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetBallooning(int onoff, int type)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBallooning(onoff, type));
        }

        public int SetBox(double xsize, double ysize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBox(xsize, ysize));
        }

        public int SetColour(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetColour(newval));
        }

        public int SetFontName(string newname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFontName(newname));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetHeight(double newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHeight(newval));
        }

        public int SetHyperlinkAddress(string newtext)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHyperlinkAddress(newtext));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetLanguageId(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLanguageId(newval));
        }

        public int SetLevel(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLevel(newval));
        }

        public int SetLinearMeasureWithoutUnit(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLinearMeasureWithoutUnit(newval));
        }

        public int SetLocking(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLocking(newval));
        }

        public int SetMode(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMode(newval));
        }

        public int SetOptionExpressions(ref object expressions)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetOptionExpressions(ref local_expressions));
            expressions = local_expressions;
            return retVal;
        }

        public int SetPictogram(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPictogram(newval));
        }

        public int SetRedlined(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRedlined(onoff));
        }

        public double SetRotation(double rotation)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRotation(rotation));
        }

        public int SetSchemaLocation(double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSchemaLocation(x, y));
        }

        public int SetSingleLine(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSingleLine(newval));
        }

        public int SetStyle(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetStyle(newval));
        }

        public int SetText(string newtext)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetText(newtext));
        }

        public int SetVisibility(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetVisibility(newval));
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

using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Graph : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Graph _raw;
        private bool _disposed;

        public e3Graph(Zuken.E3.Interop.e3Graph raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Graph RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int CreateArc(int shti, double x, double y, double radius, double start, double end)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateArc(shti, x, y, radius, start, end));
        }

        public int CreateCircle(int shti, double x, double y, double radius)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateCircle(shti, x, y, radius));
        }

        public int CreateCloud(int shti, int pnts, ref object x, ref object y)
        {
            object local_x = x;
            object local_y = y;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateCloud(shti, pnts, ref local_x, ref local_y));
            x = local_x;
            y = local_y;
            return retVal;
        }

        public int CreateCurve(int shti, int pnts, ref object x, ref object y)
        {
            object local_x = x;
            object local_y = y;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateCurve(shti, pnts, ref local_x, ref local_y));
            x = local_x;
            y = local_y;
            return retVal;
        }

        public int CreateFromSymbol(int shti, double x, double y, string rot, double scale, int maintaintextsize, string symnam, string symver)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateFromSymbol(shti, x, y, rot, scale, maintaintextsize, symnam, symver));
        }

        public int CreateGroup(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateGroup(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int CreateImage(int sheetid, double xpos, double ypos, double xsize, double ysize, string filename, int embed)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateImage(sheetid, xpos, ypos, xsize, ysize, filename, embed));
        }

        public int CreateLine(int shti, double x1, double y1, double x2, double y2)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateLine(shti, x1, y1, x2, y2));
        }

        public int CreateMeasure(int shti, double x1, double y1, double x2, double y2)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateMeasure(shti, x1, y1, x2, y2));
        }

        public int CreatePolygon(int shti, int pnts, ref object x, ref object y)
        {
            object local_x = x;
            object local_y = y;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreatePolygon(shti, pnts, ref local_x, ref local_y));
            x = local_x;
            y = local_y;
            return retVal;
        }

        public int CreateRectangle(int shti, double x1, double y1, double x2, double y2)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateRectangle(shti, x1, y1, x2, y2));
        }

        public int CreateRotatedText(int shti, string text, double x, double y, double rotation)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateRotatedText(shti, text, x, y, rotation));
        }

        public int CreateText(int shti, string text, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateText(shti, text, x, y));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int GetArc(ref object xm, ref object ym, ref object rad, ref object startang, ref object endang)
        {
            object local_xm = xm;
            object local_ym = ym;
            object local_rad = rad;
            object local_startang = startang;
            object local_endang = endang;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetArc(ref local_xm, ref local_ym, ref local_rad, ref local_startang, ref local_endang));
            xm = local_xm;
            ym = local_ym;
            rad = local_rad;
            startang = local_startang;
            endang = local_endang;
            return retVal;
        }

        public int GetArrows()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetArrows());
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

        public int GetCircle(ref object xm, ref object ym, ref object rad)
        {
            object local_xm = xm;
            object local_ym = ym;
            object local_rad = rad;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCircle(ref local_xm, ref local_ym, ref local_rad));
            xm = local_xm;
            ym = local_ym;
            rad = local_rad;
            return retVal;
        }

        public int GetCloud(ref object npnts, ref object xarr, ref object yarr)
        {
            object local_npnts = npnts;
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCloud(ref local_npnts, ref local_xarr, ref local_yarr));
            npnts = local_npnts;
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public int GetColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetColour());
        }

        public int GetCurve(ref object npnts, ref object xarr, ref object yarr)
        {
            object local_npnts = npnts;
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCurve(ref local_npnts, ref local_xarr, ref local_yarr));
            npnts = local_npnts;
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetGraphCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphCount());
        }

        public int GetGraphIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGraphIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetHatchColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHatchColour());
        }

        public double GetHatchLineDistance()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHatchLineDistance());
        }

        public int GetHatchLineStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHatchLineStyle());
        }

        public double GetHatchLineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHatchLineWidth());
        }

        public int GetHatchPattern(out object angle1, out object angle2)
        {
            object local_angle1 = default;
            object local_angle2 = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetHatchPattern(out local_angle1, out local_angle2));
            angle1 = local_angle1;
            angle2 = local_angle2;
            return retVal;
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetImageInfo(ref object xpos, ref object ypos, ref object xsize, ref object ysize, ref object filename, ref object embed)
        {
            object local_xpos = xpos;
            object local_ypos = ypos;
            object local_xsize = xsize;
            object local_ysize = ysize;
            object local_filename = filename;
            object local_embed = embed;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetImageInfo(ref local_xpos, ref local_ypos, ref local_xsize, ref local_ysize, ref local_filename, ref local_embed));
            xpos = local_xpos;
            ypos = local_ypos;
            xsize = local_xsize;
            ysize = local_ysize;
            filename = local_filename;
            embed = local_embed;
            return retVal;
        }

        public string GetInternalText()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalText());
        }

        public int GetLanguageId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLanguageId());
        }

        public int GetLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLevel());
        }

        public int GetLine(ref object x1, ref object y1, ref object x2, ref object y2)
        {
            object local_x1 = x1;
            object local_y1 = y1;
            object local_x2 = x2;
            object local_y2 = y2;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLine(ref local_x1, ref local_y1, ref local_x2, ref local_y2));
            x1 = local_x1;
            y1 = local_y1;
            x2 = local_x2;
            y2 = local_y2;
            return retVal;
        }

        public int GetLineColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineColour());
        }

        public int GetLineStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineStyle());
        }

        public double GetLineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineWidth());
        }

        public int GetParentID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParentID());
        }

        public int GetPolygon(ref object npnts, ref object xarr, ref object yarr)
        {
            object local_npnts = npnts;
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPolygon(ref local_npnts, ref local_xarr, ref local_yarr));
            npnts = local_npnts;
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public int GetRectangle(ref object x1, ref object y1, ref object x2, ref object y2)
        {
            object local_x1 = x1;
            object local_y1 = y1;
            object local_x2 = x2;
            object local_y2 = y2;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetRectangle(ref local_x1, ref local_y1, ref local_x2, ref local_y2));
            x1 = local_x1;
            y1 = local_y1;
            x2 = local_x2;
            y2 = local_y2;
            return retVal;
        }

        public string GetText()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetText());
        }

        public int GetTextColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTextColour());
        }

        public string GetTextFontName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTextFontName());
        }

        public double GetTextHeight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTextHeight());
        }

        public int GetTextLeftJustifiedSchemaLocation(ref object x, ref object y, ref object grid)
        {
            object local_x = x;
            object local_y = y;
            object local_grid = grid;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTextLeftJustifiedSchemaLocation(ref local_x, ref local_y, ref local_grid));
            x = local_x;
            y = local_y;
            grid = local_grid;
            return retVal;
        }

        public int GetTextMode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTextMode());
        }

        public double GetTextRotation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTextRotation());
        }

        public int GetTextStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTextStyle());
        }

        public int GetType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetType());
        }

        public int GetTypeId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTypeId());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int IsRedlined()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsRedlined());
        }

        public int OptimizeGraphicObjects(ref object ids, int mode, int angle)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.OptimizeGraphicObjects(ref local_ids, mode, angle));
            ids = local_ids;
            return retVal;
        }

        public int Place(double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Place(x, y));
        }

        public int SaveImage(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveImage(filename));
        }

        public int SendToBackground()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SendToBackground());
        }

        public int SendToForeground()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SendToForeground());
        }

        public int SetArrows(int newarrows)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetArrows(newarrows));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetColour(newcol));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetHatchColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHatchColour(newcol));
        }

        public double SetHatchLineDistance(double newdist)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHatchLineDistance(newdist));
        }

        public int SetHatchLineStyle(int newstyle)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHatchLineStyle(newstyle));
        }

        public double SetHatchLineWidth(double newwid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHatchLineWidth(newwid));
        }

        public int SetHatchPattern(int newpat, double angle1, double angle2)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHatchPattern(newpat, angle1, angle2));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetImageInfo(double xpos, double ypos, double xsize, double ysize, string filename, int embed)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImageInfo(xpos, ypos, xsize, ysize, filename, embed));
        }

        public int SetLanguageId(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLanguageId(newval));
        }

        public int SetLevel(int newlev)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLevel(newlev));
        }

        public int SetLineColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineColour(newcol));
        }

        public int SetLineStyle(int newstyle)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineStyle(newstyle));
        }

        public double SetLineWidth(double newwid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineWidth(newwid));
        }

        public int SetOptionExpressions(ref object expressions)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetOptionExpressions(ref local_expressions));
            expressions = local_expressions;
            return retVal;
        }

        public int SetParentID(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetParentID(id));
        }

        public int SetRedlined(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRedlined(onoff));
        }

        public int SetText(string newtext)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetText(newtext));
        }

        public int SetTextColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTextColour(newcol));
        }

        public int SetTextFontName(string newname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTextFontName(newname));
        }

        public int SetTextHeight(double hgt)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTextHeight(hgt));
        }

        public int SetTextMode(int newmod)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTextMode(newmod));
        }

        public int SetTextStyle(int newstl)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTextStyle(newstl));
        }

        public int UnGroup(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.UnGroup(ref local_ids));
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

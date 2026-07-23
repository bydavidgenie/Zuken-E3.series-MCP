using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Dimension : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Dimension _raw;
        private bool _disposed;

        public e3Dimension(Zuken.E3.Interop.e3Dimension raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Dimension RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int Create(int shtId, double x1, double y1, double x2, double y2, int flags, double distance, string text, double tx, double ty)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(shtId, x1, y1, x2, y2, flags, distance, text, tx, ty));
        }

        public int CreateEx(int dimtyp, int sheet, ref object x, ref object y, int flags)
        {
            object local_x = x;
            object local_y = y;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateEx(dimtyp, sheet, ref local_x, ref local_y, flags));
            x = local_x;
            y = local_y;
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

        public int GetArrowMode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetArrowMode());
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

        public int GetCenterTextPosition()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCenterTextPosition());
        }

        public int GetColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetColour());
        }

        public int GetDimensionedIds(ref object anyids)
        {
            object local_anyids = anyids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDimensionedIds(ref local_anyids));
            anyids = local_anyids;
            return retVal;
        }

        public string GetDisplayAttribute()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayAttribute());
        }

        public double GetExtension()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetExtension());
        }

        public double GetExtensionLineOffset()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetExtensionLineOffset());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetHideLongerPart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHideLongerPart());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLevel());
        }

        public double GetLineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineWidth());
        }

        public double GetOffset()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOffset());
        }

        public int GetParameters(out object x1, out object y1, out object x2, out object y2, out object distance, out object flags, out object text, out object tx, out object ty)
        {
            object local_x1 = default;
            object local_y1 = default;
            object local_x2 = default;
            object local_y2 = default;
            object local_distance = default;
            object local_flags = default;
            object local_text = default;
            object local_tx = default;
            object local_ty = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetParameters(out local_x1, out local_y1, out local_x2, out local_y2, out local_distance, out local_flags, out local_text, out local_tx, out local_ty));
            x1 = local_x1;
            y1 = local_y1;
            x2 = local_x2;
            y2 = local_y2;
            distance = local_distance;
            flags = local_flags;
            text = local_text;
            tx = local_tx;
            ty = local_ty;
            return retVal;
        }

        public int GetPartIds(out object ids)
        {
            object local_ids = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPartIds(out local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetPrecision()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPrecision());
        }

        public string GetPrefix()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPrefix());
        }

        public int GetRunningDimTextRotation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRunningDimTextRotation());
        }

        public string GetSuffix()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSuffix());
        }

        public double GetSuffixSizeFactor()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSuffixSizeFactor());
        }

        public int GetText(out object text, out object @fixed)
        {
            object local_text = default;
            object local_fixed = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetText(out local_text, out local_fixed));
            text = local_text;
            @fixed = local_fixed;
            return retVal;
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

        public int GetTextStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTextStyle());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int IsAlongPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsAlongPath());
        }

        public int IsPartOfDimension()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPartOfDimension());
        }

        public int IsRedlined()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsRedlined());
        }

        public int IsRunningDimension()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsRunningDimension());
        }

        public int SetArrowMode(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetArrowMode(value));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetCenterTextPosition(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCenterTextPosition(value));
        }

        public int SetColour(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetColour(value));
        }

        public int SetDisplayAttribute(string attnam)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayAttribute(attnam));
        }

        public double SetExtension(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetExtension(value));
        }

        public double SetExtensionLineOffset(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetExtensionLineOffset(value));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetHideLongerPart(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHideLongerPart(value));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetLevel(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLevel(value));
        }

        public double SetLineWidth(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineWidth(value));
        }

        public double SetOffset(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetOffset(value));
        }

        public int SetPrecision(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrecision(value));
        }

        public string SetPrefix(string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrefix(value));
        }

        public int SetRedlined(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRedlined(onoff));
        }

        public int SetRunningDimTextRotation(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRunningDimTextRotation(value));
        }

        public string SetSuffix(string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSuffix(value));
        }

        public double SetSuffixSizeFactor(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSuffixSizeFactor(value));
        }

        public int SetText(string text, int @fixed)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetText(text, @fixed));
        }

        public int SetTextColour(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTextColour(value));
        }

        public string SetTextFontName(string text)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTextFontName(text));
        }

        public double SetTextHeight(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTextHeight(value));
        }

        public int SetTextStyle(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTextStyle(value));
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

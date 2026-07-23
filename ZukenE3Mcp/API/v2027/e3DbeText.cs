using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3DbeText : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeText _raw;
        private bool _disposed;

        public e3DbeText(Zuken.E3.Interop.e3DbeText raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeText RawObject => _raw;

        public int Create(int id, int texttype, double x, double y, string textvalue)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(id, texttype, x, y, textvalue));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int GetAlignment()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAlignment());
        }

        public int GetBallooning()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBallooning());
        }

        public int GetColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetColour());
        }

        public string GetFontName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFontName());
        }

        public double GetHeight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHeight());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLevel());
        }

        public int GetLocking()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocking());
        }

        public int GetMode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMode());
        }

        public int GetPosition(ref object x, ref object y)
        {
            object local_x = x;
            object local_y = y;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPosition(ref local_x, ref local_y));
            x = local_x;
            y = local_y;
            return retVal;
        }

        public double GetRotation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRotation());
        }

        public int GetSingleLine()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSingleLine());
        }

        public int GetSource()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSource());
        }

        public int GetStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetStyle());
        }

        public string GetText()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetText());
        }

        public int GetType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetType());
        }

        public int GetVisibility()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVisibility());
        }

        public int SetAlignment(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAlignment(newval));
        }

        public int SetBallooning(int onoff, int type)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBallooning(onoff, type));
        }

        public int SetColour(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetColour(value));
        }

        public int SetFontName(string newname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFontName(newname));
        }

        public int SetHeight(double newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHeight(newval));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetLevel(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLevel(newval));
        }

        public int SetLocking(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLocking(newval));
        }

        public int SetMode(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMode(newval));
        }

        public double SetRotation(double rotation)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRotation(rotation));
        }

        public int SetSingleLine(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSingleLine(newval));
        }

        public int SetSource(int textSource)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSource(textSource));
        }

        public int SetStyle(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetStyle(newval));
        }

        public int SetText(string newtext)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetText(newtext));
        }

        public int SetType(int texttype)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetType(texttype));
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

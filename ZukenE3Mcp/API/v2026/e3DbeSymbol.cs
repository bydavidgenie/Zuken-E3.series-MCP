using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3DbeSymbol : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeSymbol _raw;
        private bool _disposed;

        public e3DbeSymbol(Zuken.E3.Interop.e3DbeSymbol raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeSymbol RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int FitSpaceRequirement()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FitSpaceRequirement());
        }

        public int GetAttributeIds(ref object ids, string attnam)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeIds(ref local_ids, attnam));
            ids = local_ids;
            return retVal;
        }

        public string GetCharacteristic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCharacteristic());
        }

        public int GetDXFSize(string filename, string font, ref object dx, ref object dy, ref object scale)
        {
            object local_dx = dx;
            object local_dy = dy;
            object local_scale = scale;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDXFSize(filename, font, ref local_dx, ref local_dy, ref local_scale));
            dx = local_dx;
            dy = local_dy;
            scale = local_scale;
            return retVal;
        }

        public int GetGraphicIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGraphicIds(ref local_ids));
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

        public int GetNodeIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNodeIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetSubType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSubType());
        }

        public int GetSymbolType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolType());
        }

        public int GetTextIds(ref object ids, int texttype)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTextIds(ref local_ids, texttype));
            ids = local_ids;
            return retVal;
        }

        public string GetVersion()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVersion());
        }

        public int ImportDXF(string filename, double scale, double x, double y, int rot, string font, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ImportDXF(filename, scale, x, y, rot, font, flags));
        }

        public int PlaceSymbol(string symname, string version, double x, double y, string rot, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceSymbol(symname, version, x, y, rot, flags));
        }

        public int Remove(int save_changes)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Remove(save_changes));
        }

        public int Save()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Save());
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetSubType(int subtype)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSubType(subtype));
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

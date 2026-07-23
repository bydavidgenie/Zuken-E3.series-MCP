using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3DbeModel : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeModel _raw;
        private bool _disposed;

        public e3DbeModel(Zuken.E3.Interop.e3DbeModel raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeModel RawObject => _raw;

        public int ActivateModelView(int modelview)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ActivateModelView(modelview));
        }

        public int AddAttributeValue(string name, string value, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value, flags));
        }

        public int DeleteModelView(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteModelView(flags));
        }

        public int DeleteStepModel(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteStepModel(flags));
        }

        public int DisplayOverviewOfExistingViews(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayOverviewOfExistingViews(flags));
        }

        public int ExportImage(string format, int version, string file, int dpi, int compressionmode, int clrdepth, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportImage(format, version, file, dpi, compressionmode, clrdepth, flags));
        }

        public int ExportImageArea(string format, int version, string file, double xl, double yl, double xr, double yr, int width, int height, int clrdepth, int gray, int dpiX, int dpiY, int compressionmode, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportImageArea(format, version, file, xl, yl, xr, yr, width, height, clrdepth, gray, dpiX, dpiY, compressionmode, flags));
        }

        public int FitSpaceRequirement()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FitSpaceRequirement());
        }

        public int GetAttributeIds(ref object ids, string attnam, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeIds(ref local_ids, attnam, flags));
            ids = local_ids;
            return retVal;
        }

        public string GetCharacteristic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCharacteristic());
        }

        public int GetDrawingArea(ref object xmin, ref object ymin, ref object xmax, ref object ymax, int flags)
        {
            object local_xmin = xmin;
            object local_ymin = ymin;
            object local_xmax = xmax;
            object local_ymax = ymax;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDrawingArea(ref local_xmin, ref local_ymin, ref local_xmax, ref local_ymax, flags));
            xmin = local_xmin;
            ymin = local_ymin;
            xmax = local_xmax;
            ymax = local_ymax;
            return retVal;
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

        public int GetDXFSizeEx(string filename, string font, ref object dx, ref object dy, ref object scale, ref object flags)
        {
            object local_dx = dx;
            object local_dy = dy;
            object local_scale = scale;
            object local_flags = flags;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDXFSizeEx(filename, font, ref local_dx, ref local_dy, ref local_scale, ref local_flags));
            dx = local_dx;
            dy = local_dy;
            scale = local_scale;
            flags = local_flags;
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

        public int GetJustificationArea(out object z, int flags)
        {
            object local_z = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetJustificationArea(out local_z, flags));
            z = local_z;
            return retVal;
        }

        public int GetJustificationLine(out object y, out object z, int flags)
        {
            object local_y = default;
            object local_z = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetJustificationLine(out local_y, out local_z, flags));
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int GetJustificationPoint(out object x, out object y, out object z, int flags)
        {
            object local_x = default;
            object local_y = default;
            object local_z = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetJustificationPoint(out local_x, out local_y, out local_z, flags));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int GetMountingDescriptions(ref object mountingdescriptions, int flags)
        {
            object local_mountingdescriptions = mountingdescriptions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetMountingDescriptions(ref local_mountingdescriptions, flags));
            mountingdescriptions = local_mountingdescriptions;
            return retVal;
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSlotIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSlotIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetStepTransformation(out object matrix, int flags)
        {
            object local_matrix = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetStepTransformation(out local_matrix, flags));
            matrix = local_matrix;
            return retVal;
        }

        public int ImportDXF(string filename, double scale, double x, double y, int rot, string font, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ImportDXF(filename, scale, x, y, rot, font, flags));
        }

        public int ImportStep(string filename, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ImportStep(filename, flags));
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

        public int SetJustificationArea(double z, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetJustificationArea(z, flags));
        }

        public int SetJustificationLine(double y, double z, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetJustificationLine(y, z, flags));
        }

        public int SetJustificationPoint(double x, double y, double z, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetJustificationPoint(x, y, z, flags));
        }

        public int SetMountingDescriptions(ref object mountingdescriptions, int flags)
        {
            object local_mountingdescriptions = mountingdescriptions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetMountingDescriptions(ref local_mountingdescriptions, flags));
            mountingdescriptions = local_mountingdescriptions;
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

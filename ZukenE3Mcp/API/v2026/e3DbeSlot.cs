using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3DbeSlot : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeSlot _raw;
        private bool _disposed;

        public e3DbeSlot(Zuken.E3.Interop.e3DbeSlot raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeSlot RawObject => _raw;

        public int CreateAreaPolygon(int modelid, ref object xarr, ref object yarr, ref object zarr, double xdir, double ydir, double zdir, string description, string name, int flags)
        {
            object local_xarr = xarr;
            object local_yarr = yarr;
            object local_zarr = zarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateAreaPolygon(modelid, ref local_xarr, ref local_yarr, ref local_zarr, xdir, ydir, zdir, description, name, flags));
            xarr = local_xarr;
            yarr = local_yarr;
            zarr = local_zarr;
            return retVal;
        }

        public int CreateAreaRectangle(int modelid, double xpos, double ypos, double zpos, double xdir, double ydir, double zdir, double length, double width, string description, string name, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateAreaRectangle(modelid, xpos, ypos, zpos, xdir, ydir, zdir, length, width, description, name, flags));
        }

        public int CreateLine(int modelid, double xpos, double ypos, double zpos, double xdir, double ydir, double zdir, double length, double width, double rotation, string description, string name, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateLine(modelid, xpos, ypos, zpos, xdir, ydir, zdir, length, width, rotation, description, name, flags));
        }

        public int CreatePoint(int modelid, double xpos, double ypos, double zpos, double xdir, double ydir, double zdir, double rotation, string description, string name, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreatePoint(modelid, xpos, ypos, zpos, xdir, ydir, zdir, rotation, description, name, flags));
        }

        public int Delete(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete(flags));
        }

        public int GetAreaPolygon(ref object xarr, ref object yarr, ref object zarr, int flags)
        {
            object local_xarr = xarr;
            object local_yarr = yarr;
            object local_zarr = zarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAreaPolygon(ref local_xarr, ref local_yarr, ref local_zarr, flags));
            xarr = local_xarr;
            yarr = local_yarr;
            zarr = local_zarr;
            return retVal;
        }

        public int GetDirection(out object x, out object y, out object z)
        {
            object local_x = default;
            object local_y = default;
            object local_z = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDirection(out local_x, out local_y, out local_z));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int GetDirectionEx(out object x, out object y, out object z, out object side, int flags)
        {
            object local_x = default;
            object local_y = default;
            object local_z = default;
            object local_side = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDirectionEx(out local_x, out local_y, out local_z, out local_side, flags));
            x = local_x;
            y = local_y;
            z = local_z;
            side = local_side;
            return retVal;
        }

        public int GetDirectionRotation(out object xAxisRotation, out object yAxisRotation, out object zAxisRotation, int flags)
        {
            object local_xAxisRotation = default;
            object local_yAxisRotation = default;
            object local_zAxisRotation = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDirectionRotation(out local_xAxisRotation, out local_yAxisRotation, out local_zAxisRotation, flags));
            xAxisRotation = local_xAxisRotation;
            yAxisRotation = local_yAxisRotation;
            zAxisRotation = local_zAxisRotation;
            return retVal;
        }

        public int GetFixType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFixType());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetLength(out object length, int flags)
        {
            object local_length = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLength(out local_length, flags));
            length = local_length;
            return retVal;
        }

        public string GetMountType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMountType());
        }

        public int GetPosition(int point, ref object x, ref object y, ref object z)
        {
            object local_x = x;
            object local_y = y;
            object local_z = z;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPosition(point, ref local_x, ref local_y, ref local_z));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int GetRotation(out object angle)
        {
            object local_angle = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetRotation(out local_angle));
            angle = local_angle;
            return retVal;
        }

        public string GetSlotName(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSlotName(flags));
        }

        public int GetWidth(out object width, int flags)
        {
            object local_width = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetWidth(out local_width, flags));
            width = local_width;
            return retVal;
        }

        public int SetDirectionRotation(double xAxisRotation, double yAxisRotation, double zAxisRotation, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDirectionRotation(xAxisRotation, yAxisRotation, zAxisRotation, flags));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetLength(double length, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLength(length, flags));
        }

        public int SetRotation(double rotation, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRotation(rotation, flags));
        }

        public int SetSlotName(string name, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSlotName(name, flags));
        }

        public int SetWidth(double width, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetWidth(width, flags));
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

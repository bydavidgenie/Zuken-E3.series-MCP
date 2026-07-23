using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3Slot : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Slot _raw;
        private bool _disposed;

        public e3Slot(Zuken.E3.Interop.e3Slot raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Slot RawObject => _raw;

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

        public int GetDefinedDirection(out object x, out object y, out object z)
        {
            object local_x = default;
            object local_y = default;
            object local_z = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDefinedDirection(out local_x, out local_y, out local_z));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int GetDefinedRotation(out object angle, int flags)
        {
            object local_angle = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDefinedRotation(out local_angle, flags));
            angle = local_angle;
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

        public int GetFixType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFixType());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetMountedDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetMountedDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetMountType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMountType());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
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

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetMountType(string newval, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMountType(newval, flags));
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

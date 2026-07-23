using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3ConnectLine : IDisposable
    {
        private readonly Zuken.E3.Interop.e3ConnectLine _raw;
        private bool _disposed;

        public e3ConnectLine(Zuken.E3.Interop.e3ConnectLine raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3ConnectLine RawObject => _raw;

        public int AddProtectionSymbolId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddProtectionSymbolId(id));
        }

        public int GetAssignedOptionExpressions(out object expressions, int Term)
        {
            object local_expressions = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAssignedOptionExpressions(out local_expressions, Term));
            expressions = local_expressions;
            return retVal;
        }

        public int GetCoordinates(ref object xarr, ref object yarr, ref object zarr, ref object PointTypArr)
        {
            object local_xarr = xarr;
            object local_yarr = yarr;
            object local_zarr = zarr;
            object local_PointTypArr = PointTypArr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCoordinates(ref local_xarr, ref local_yarr, ref local_zarr, ref local_PointTypArr));
            xarr = local_xarr;
            yarr = local_yarr;
            zarr = local_zarr;
            PointTypArr = local_PointTypArr;
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

        public int GetProtectionSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetProtectionSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
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

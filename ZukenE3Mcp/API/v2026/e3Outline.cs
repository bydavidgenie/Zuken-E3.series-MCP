using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Outline : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Outline _raw;
        private bool _disposed;

        public e3Outline(Zuken.E3.Interop.e3Outline raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Outline RawObject => _raw;

        public int CreateBoardOutline(int brdi, int pnts, ref object x, ref object y)
        {
            object local_x = x;
            object local_y = y;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateBoardOutline(brdi, pnts, ref local_x, ref local_y));
            x = local_x;
            y = local_y;
            return retVal;
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public double GetHeight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHeight());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetPath(ref object xarr, ref object yarr)
        {
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPath(ref local_xarr, ref local_yarr));
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public int GetPathEx(ref object xarr, ref object yarr, ref object zarr)
        {
            object local_xarr = xarr;
            object local_yarr = yarr;
            object local_zarr = zarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPathEx(ref local_xarr, ref local_yarr, ref local_zarr));
            xarr = local_xarr;
            yarr = local_yarr;
            zarr = local_zarr;
            return retVal;
        }

        public int GetPosition(ref object x, ref object y, ref object z)
        {
            object local_x = x;
            object local_y = y;
            object local_z = z;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPosition(ref local_x, ref local_y, ref local_z));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public double GetRadius()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRadius());
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

        public int GetType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetType());
        }

        public int GetTypeId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTypeId());
        }

        public int IsThreadedHole()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsThreadedHole());
        }

        public int SetCreatesThreadedHole(int set, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCreatesThreadedHole(set, flags));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetUseCutOutGraphic(int set)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUseCutOutGraphic(set));
        }

        public int SetUseInE3CutOut(int set)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUseInE3CutOut(set));
        }

        public int UseCutOutGraphic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UseCutOutGraphic());
        }

        public int UseInE3CutOut()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UseInE3CutOut());
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

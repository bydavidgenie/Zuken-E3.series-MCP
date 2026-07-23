using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3Wespe : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Wespe _raw;
        private bool _disposed;

        public e3Wespe(Zuken.E3.Interop.e3Wespe raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Wespe RawObject => _raw;

        public int ChangeTextTo(int ttyp, int txtid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ChangeTextTo(ttyp, txtid));
        }

        public e3Job CreateProject(string name)
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateProject(name));
            return rawResult != null ? new e3Job((Zuken.E3.Interop.e3Job)rawResult) : null;
        }

        public int CreateText(int ttyp, string value, int shtId, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateText(ttyp, value, shtId, x, y));
        }

        public int DeleteText(int txtid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteText(txtid));
        }

        public int DisintegrateDynamic(int symid, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DisintegrateDynamic(symid, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCursorPosition(out object x, out object y, out object c, out object vk, out object modflg)
        {
            object local_x = default;
            object local_y = default;
            object local_c = default;
            object local_vk = default;
            object local_modflg = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCursorPosition(out local_x, out local_y, out local_c, out local_vk, out local_modflg));
            x = local_x;
            y = local_y;
            c = local_c;
            vk = local_vk;
            modflg = local_modflg;
            return retVal;
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetInsideSymbolIds(int fldid, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsideSymbolIds(fldid, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNodeIds(int shti, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNodeIds(shti, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int IdentifyGraphIds(int shtId, ref object ids, double px, double py, double snap, int Visible)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.IdentifyGraphIds(shtId, ref local_ids, px, py, snap, Visible));
            ids = local_ids;
            return retVal;
        }

        public int IdentifyNetSegmentIds(int shtId, ref object ids, double px, double py, double snap, int Visible)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.IdentifyNetSegmentIds(shtId, ref local_ids, px, py, snap, Visible));
            ids = local_ids;
            return retVal;
        }

        public int IdentifyNodePoint(int shtId, out object fx, out object fy, double px, double py, double snap, int Visible)
        {
            object local_fx = default;
            object local_fy = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.IdentifyNodePoint(shtId, out local_fx, out local_fy, px, py, snap, Visible));
            fx = local_fx;
            fy = local_fy;
            return retVal;
        }

        public int IdentifySymbolIds(int shtId, ref object ids, double px, double py, double snap, int Visible)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.IdentifySymbolIds(shtId, ref local_ids, px, py, snap, Visible));
            ids = local_ids;
            return retVal;
        }

        public int IdentifyTextIds(int shtId, ref object ids, double px, double py, double snap, int Visible)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.IdentifyTextIds(shtId, ref local_ids, px, py, snap, Visible));
            ids = local_ids;
            return retVal;
        }

        public e3Sheet ImportSheet(string name, string filename)
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.ImportSheet(name, filename));
            return rawResult != null ? new e3Sheet((Zuken.E3.Interop.e3Sheet)rawResult) : null;
        }

        public int MergeIdsToDynamic(int symid, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.MergeIdsToDynamic(symid, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int MoveIds(ref object ids, int inside_only, int structlimit, double offx, double offy, ref object modids)
        {
            object local_ids = ids;
            object local_modids = modids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.MoveIds(ref local_ids, inside_only, structlimit, offx, offy, ref local_modids));
            ids = local_ids;
            modids = local_modids;
            return retVal;
        }

        public int PlacePart(string name, string version, int symid, int shtId, double x, double y, double rot)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlacePart(name, version, symid, shtId, x, y, rot));
        }

        public int PlacePartInteractively(string name, string version, int symid, out object x, out object y, out object rot)
        {
            object local_x = default;
            object local_y = default;
            object local_rot = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PlacePartInteractively(name, version, symid, out local_x, out local_y, out local_rot));
            x = local_x;
            y = local_y;
            rot = local_rot;
            return retVal;
        }

        public int PlacePolygonField(int shti, int pnts, ref object x, ref object y, int moveall)
        {
            object local_x = x;
            object local_y = y;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PlacePolygonField(shti, pnts, ref local_x, ref local_y, moveall));
            x = local_x;
            y = local_y;
            return retVal;
        }

        public int SaveProject(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveProject(name));
        }

        public int SetGraphLine(int gri, double x1, double y1, double x2, double y2)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphLine(gri, x1, y1, x2, y2));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetParentApp(e3Application app)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetParentApp(app?.RawObject));
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

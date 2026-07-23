using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Bundle : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Bundle _raw;
        private bool _disposed;

        public e3Bundle(Zuken.E3.Interop.e3Bundle raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Bundle RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int Capture(ref object cabwirids)
        {
            object local_cabwirids = cabwirids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Capture(ref local_cabwirids));
            cabwirids = local_cabwirids;
            return retVal;
        }

        public int Create(ref object aroundids)
        {
            object local_aroundids = aroundids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Create(ref local_aroundids));
            aroundids = local_aroundids;
            return retVal;
        }

        public int CreateBundle(ref object aroundids)
        {
            object local_aroundids = aroundids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateBundle(ref local_aroundids));
            aroundids = local_aroundids;
            return retVal;
        }

        public int CreateBundleIn(int cableid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateBundleIn(cableid));
        }

        public int CreateIn(int cableid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateIn(cableid));
        }

        public int CreateShield(ref object aroundids)
        {
            object local_aroundids = aroundids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateShield(ref local_aroundids));
            aroundids = local_aroundids;
            return retVal;
        }

        public int CreateShieldIn(int cableid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateShieldIn(cableid));
        }

        public int CreateTwist(ref object aroundids)
        {
            object local_aroundids = aroundids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateTwist(ref local_aroundids));
            aroundids = local_aroundids;
            return retVal;
        }

        public int CreateTwistIn(int cableid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateTwistIn(cableid));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int GetAnyCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAnyCount());
        }

        public int GetAnyIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAnyIds(ref local_ids));
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

        public int GetBundleCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBundleCount());
        }

        public int GetBundleIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBundleIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCableCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCableCount());
        }

        public int GetCableIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCableIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCoreCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCoreCount());
        }

        public int GetCoreIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCoreIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public string GetGUID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGUID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetOverbraidId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOverbraidId());
        }

        public int GetOverbraidIdEx()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOverbraidIdEx());
        }

        public int GetParentBundleId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParentBundleId());
        }

        public int GetPinCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinCount());
        }

        public int GetPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetRootBundleId(int bndid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRootBundleId(bndid));
        }

        public int GetRootOverbraidId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRootOverbraidId());
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

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int IsBundle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBundle());
        }

        public int IsShield()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsShield());
        }

        public int IsTwisted()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsTwisted());
        }

        public int PlaceAll()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceAll());
        }

        public int ReleaseIDs(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ReleaseIDs(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public string SetGUID(string guid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGUID(guid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
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

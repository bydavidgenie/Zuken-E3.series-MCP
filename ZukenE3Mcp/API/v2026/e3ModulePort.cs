using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3ModulePort : IDisposable
    {
        private readonly Zuken.E3.Interop.e3ModulePort _raw;
        private bool _disposed;

        public e3ModulePort(Zuken.E3.Interop.e3ModulePort raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3ModulePort RawObject => _raw;

        public string GetBusName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBusName());
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

        public int GetModuleId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetModuleId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetSignalId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalId());
        }

        public int GetSignalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSignalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSymbolIds(ref object OnBlockId, ref object OnSheetId)
        {
            object local_OnBlockId = OnBlockId;
            object local_OnSheetId = OnSheetId;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolIds(ref local_OnBlockId, ref local_OnSheetId));
            OnBlockId = local_OnBlockId;
            OnSheetId = local_OnSheetId;
            return retVal;
        }

        public int IsBus()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBus());
        }

        public int SetBusName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBusName(name));
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

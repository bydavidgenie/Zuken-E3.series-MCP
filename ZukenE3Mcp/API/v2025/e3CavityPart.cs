using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3CavityPart : IDisposable
    {
        private readonly Zuken.E3.Interop.e3CavityPart _raw;
        private bool _disposed;

        public e3CavityPart(Zuken.E3.Interop.e3CavityPart raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3CavityPart RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int Create(int pinid, string name, int type)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(pinid, name, type));
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public string GetAttributeValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeValue(name));
        }

        public int GetCabwirInfos(ref object cabWirs)
        {
            object local_cabWirs = cabWirs;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCabwirInfos(ref local_cabWirs));
            cabWirs = local_cabWirs;
            return retVal;
        }

        public int GetCavityPartType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCavityPartType());
        }

        public int GetDisableAutomaticSelection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisableAutomaticSelection());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetOwner()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOwner());
        }

        public string GetValue()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetValue());
        }

        public int IsActive()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsActive());
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetDisableAutomaticSelection(int DisableAutomaticSelection)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisableAutomaticSelection(DisableAutomaticSelection));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetValue(string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetValue(value));
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

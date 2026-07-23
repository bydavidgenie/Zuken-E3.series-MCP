using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Component : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Component _raw;
        private bool _disposed;

        public e3Component(Zuken.E3.Interop.e3Component raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Component RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
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

        public int GetComponentType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentType());
        }

        public int GetFormboardSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetFormboardSymbolIds(ref local_ids));
            ids = local_ids;
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

        public string GetModelName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetModelName());
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

        public int GetStateIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetStateIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSubType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSubType());
        }

        public int GetSupplyPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSupplyPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetValidModelCharacteristics(ref object characteristics)
        {
            object local_characteristics = characteristics;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetValidModelCharacteristics(ref local_characteristics));
            characteristics = local_characteristics;
            return retVal;
        }

        public string GetVersion()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVersion());
        }

        public int GetViewDefinitions(ref object viewDefinitions)
        {
            object local_viewDefinitions = viewDefinitions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetViewDefinitions(ref local_viewDefinitions));
            viewDefinitions = local_viewDefinitions;
            return retVal;
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int Rename(string name, string version)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Rename(name, version));
        }

        public int Search(string name, string version)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(name, version));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
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

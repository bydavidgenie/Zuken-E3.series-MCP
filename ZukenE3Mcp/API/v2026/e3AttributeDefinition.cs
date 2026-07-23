using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3AttributeDefinition : IDisposable
    {
        private readonly Zuken.E3.Interop.e3AttributeDefinition _raw;
        private bool _disposed;

        public e3AttributeDefinition(Zuken.E3.Interop.e3AttributeDefinition raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3AttributeDefinition RawObject => _raw;

        public int Create(string name, ref object attributeDefinition)
        {
            object local_attributeDefinition = attributeDefinition;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Create(name, ref local_attributeDefinition));
            attributeDefinition = local_attributeDefinition;
            return retVal;
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int Get(out object attributeDefinition)
        {
            object local_attributeDefinition = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Get(out local_attributeDefinition));
            attributeDefinition = local_attributeDefinition;
            return retVal;
        }

        public int GetAttributeListValues(string attributelistname, out object values, int flags)
        {
            object local_values = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeListValues(attributelistname, out local_values, flags));
            values = local_values;
            return retVal;
        }

        public int GetFromDatabase(out object attributeDefinitions)
        {
            object local_attributeDefinitions = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetFromDatabase(out local_attributeDefinitions));
            attributeDefinitions = local_attributeDefinitions;
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

        public string GetInternalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalName());
        }

        public string GetName(int languageId)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName(languageId));
        }

        public string GetValueListName(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetValueListName(flags));
        }

        public int Search(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(name));
        }

        public int set(ref object attributeDefinition)
        {
            object local_attributeDefinition = attributeDefinition;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.set(ref local_attributeDefinition));
            attributeDefinition = local_attributeDefinition;
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

        public int SetName(int languageId, string newname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(languageId, newname));
        }

        public int Update(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Update(flags));
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

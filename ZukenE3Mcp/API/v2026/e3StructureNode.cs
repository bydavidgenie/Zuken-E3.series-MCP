using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3StructureNode : IDisposable
    {
        private readonly Zuken.E3.Interop.e3StructureNode _raw;
        private bool _disposed;

        public e3StructureNode(Zuken.E3.Interop.e3StructureNode raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3StructureNode RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int Create(string name, string typname, int parentid, int afterid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name, typname, parentid, afterid));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DeleteForced()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteForced());
        }

        public int GetAllDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetAllSignalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllSignalIds(ref local_ids));
            ids = local_ids;
            return retVal;
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

        public int GetExternalDocumentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetExternalDocumentIds(ref local_ids));
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

        public string GetInternalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalName());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetParentID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParentID());
        }

        public int GetSheetAndExternalDocumentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSheetAndExternalDocumentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetStructureNodeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetStructureNodeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetTypeName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTypeName());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int Highlight(int colour, double width)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Highlight(colour, width));
        }

        public int IsLocked()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLocked());
        }

        public int IsLockedByAccessControl()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLockedByAccessControl());
        }

        public int IsObjectTypeAllowed(int sheets, int devices)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsObjectTypeAllowed(sheets, devices));
        }

        public int LockObject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LockObject());
        }

        public int MoveTo(int parentid, int afterid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.MoveTo(parentid, afterid));
        }

        public int ResetHighlight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetHighlight());
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetExternalDocumentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetExternalDocumentIds(ref local_ids));
            ids = local_ids;
            return retVal;
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

        public int SetSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int SetStructureNodeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetStructureNodeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int UnlockObject(string password)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnlockObject(password));
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

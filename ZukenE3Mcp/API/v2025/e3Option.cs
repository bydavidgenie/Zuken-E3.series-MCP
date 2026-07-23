using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3Option : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Option _raw;
        private bool _disposed;

        public e3Option(Zuken.E3.Interop.e3Option raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Option RawObject => _raw;

        public int Activate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Activate());
        }

        public int ActivateAndLockOtherActivations()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ActivateAndLockOtherActivations());
        }

        public int Add(int devi)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Add(devi));
        }

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int AssignToID(int parentid, int how)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AssignToID(parentid, how));
        }

        public int Create(string name, int parent, int position, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name, parent, position, before));
        }

        public int CreateConfiguration(string name, int posId, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateConfiguration(name, posId, before));
        }

        public int CreateHarnessDerivative(string name, int posId, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateHarnessDerivative(name, posId, before));
        }

        public int CreateHarnessFamily(string name, int posId, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateHarnessFamily(name, posId, before));
        }

        public int CreatePackage(string name, int posId, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreatePackage(name, posId, before));
        }

        public int Deactivate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Deactivate());
        }

        public int Delete(int del)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete(del));
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int GetAllDeviantAttributeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllDeviantAttributeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetAllDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllDeviceIds(ref local_ids));
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

        public string GetDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDescription());
        }

        public int GetExclusiveOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetExclusiveOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetFieldIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetFieldIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetFullInternalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFullInternalName());
        }

        public string GetFullName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFullName());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetGraphIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGraphIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetGUID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGUID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetInclusiveOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInclusiveOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetInternalDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalDescription());
        }

        public string GetInternalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalName());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetParentOptionId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParentOptionId());
        }

        public int GetPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetPropertyFlags()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPropertyFlags());
        }

        public int GetSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTextIds(ref object ids, int txttyp, string search_string)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTextIds(ref local_ids, txttyp, search_string));
            ids = local_ids;
            return retVal;
        }

        public string GetXMLVariantID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetXMLVariantID());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int Highlight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Highlight());
        }

        public int IsActive()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsActive());
        }

        public int IsAssignable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsAssignable());
        }

        public int IsConfiguration()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsConfiguration());
        }

        public int IsHarnessDerivative()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsHarnessDerivative());
        }

        public int IsHarnessFamily()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsHarnessFamily());
        }

        public int IsHighlighted()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsHighlighted());
        }

        public int IsInUseByObject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsInUseByObject());
        }

        public int IsObjectActive(int objid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsObjectActive(objid));
        }

        public int IsPackage()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPackage());
        }

        public int IsVariant()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsVariant());
        }

        public int MoveTo(int vari, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.MoveTo(vari, before));
        }

        public int Remove(int devi)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Remove(devi));
        }

        public int ResetHighlight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetHighlight());
        }

        public int Search(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(name));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetDescription(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDescription(newval));
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

        public int SetPropertyFlags(int newflags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPropertyFlags(newflags));
        }

        public int SetXMLVariantID(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetXMLVariantID(name));
        }

        public int Sort(int sortMode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Sort(sortMode));
        }

        public int UnassignFromID(int parentid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnassignFromID(parentid));
        }

        public int UnLockOtherActivations()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnLockOtherActivations());
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

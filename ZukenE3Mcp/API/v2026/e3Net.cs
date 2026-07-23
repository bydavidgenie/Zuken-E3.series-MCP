using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Net : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Net _raw;
        private bool _disposed;

        public e3Net(Zuken.E3.Interop.e3Net raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Net RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DisplayAttributeValueAt(string name, int sheetid, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayAttributeValueAt(name, sheetid, x, y));
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

        public int GetHarnessId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHarnessId());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetNetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetParentID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParentID());
        }

        public int GetPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetSignalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalName());
        }

        public string GetTranslatedSignalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTranslatedSignalName());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int IsSignalTransferred()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsSignalTransferred());
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetAttributeVisibility(string name, int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeVisibility(name, onoff));
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

        public int SetSignalName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSignalName(name));
        }

        public int SetSignalNameOnLocalNet(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSignalNameOnLocalNet(name));
        }

        public int SetTransferSignal(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTransferSignal(value));
        }

        public int SplitHarness()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SplitHarness());
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

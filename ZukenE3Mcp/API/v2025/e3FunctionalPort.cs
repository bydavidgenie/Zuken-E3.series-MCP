using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3FunctionalPort : IDisposable
    {
        private readonly Zuken.E3.Interop.e3FunctionalPort _raw;
        private bool _disposed;

        public e3FunctionalPort(Zuken.E3.Interop.e3FunctionalPort raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3FunctionalPort RawObject => _raw;

        public int Create(int fuId, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(fuId, name));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int GetConnectedPorts(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectedPorts(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetConnectorName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectorName());
        }

        public int GetConnectorPinID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectorPinID());
        }

        public int GetFunctionalUnitId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFunctionalUnitId());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetNodeID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNodeID());
        }

        public int GetPinID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinID());
        }

        public string GetPinName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinName());
        }

        public int GetPortType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPortType());
        }

        public int GetSignalEquiv()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalEquiv());
        }

        public int GetSignalEqvPorts(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSignalEqvPorts(ref local_ids));
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

        public int GetUserDefined()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetUserDefined());
        }

        public string SetConnectorName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetConnectorName(name));
        }

        public int SetConnectorPinID(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetConnectorPinID(id));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
        }

        public int SetNodeId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetNodeId(id));
        }

        public int SetPinID(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPinID(id));
        }

        public string SetPinName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPinName(name));
        }

        public int SetPortType(int type)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPortType(type));
        }

        public int SetSignalEquiv(int signalequiv)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSignalEquiv(signalequiv));
        }

        public int SetSignalName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSignalName(name));
        }

        public int SetUserDefined(int type)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUserDefined(type));
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

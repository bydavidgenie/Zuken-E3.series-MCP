using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3DbeModelPin : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeModelPin _raw;
        private bool _disposed;

        public e3DbeModelPin(Zuken.E3.Interop.e3DbeModelPin raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeModelPin RawObject => _raw;

        public int GetCrimpingRules(ref object rules)
        {
            object local_rules = rules;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCrimpingRules(ref local_rules));
            rules = local_rules;
            return retVal;
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetPinProperties(string keyList, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinProperties(keyList, flags));
        }

        public int GetRoutingOffset(ref object x, ref object y, ref object z, int flags)
        {
            object local_x = x;
            object local_y = y;
            object local_z = z;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetRoutingOffset(ref local_x, ref local_y, ref local_z, flags));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int SetCrimpingRules(ref object rules)
        {
            object local_rules = rules;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetCrimpingRules(ref local_rules));
            rules = local_rules;
            return retVal;
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetPinProperties(string jsonInput, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPinProperties(jsonInput, flags));
        }

        public int SetRoutingOffset(double x, double y, double z, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRoutingOffset(x, y, z, flags));
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

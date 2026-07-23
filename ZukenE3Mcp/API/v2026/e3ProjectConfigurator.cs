using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3ProjectConfigurator : IDisposable
    {
        private readonly Zuken.E3.Interop.e3ProjectConfigurator _raw;
        private bool _disposed;

        public e3ProjectConfigurator(Zuken.E3.Interop.e3ProjectConfigurator raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3ProjectConfigurator RawObject => _raw;

        public int AddAttribute(out object errorMessages, int targetId, string attributeName, string value, int objectType1, int objectType2, string name, int flags)
        {
            object local_errorMessages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AddAttribute(out local_errorMessages, targetId, attributeName, value, objectType1, objectType2, name, flags));
            errorMessages = local_errorMessages;
            return retVal;
        }

        public int ChangeComponent(out object errorMessages, int targetId, string NewComponent, string oldComponent, string newVersion, string oldVersion, int flags)
        {
            object local_errorMessages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ChangeComponent(out local_errorMessages, targetId, NewComponent, oldComponent, newVersion, oldVersion, flags));
            errorMessages = local_errorMessages;
            return retVal;
        }

        public int ChangeSignal(out object errorMessages, int targetId, string oldSignalName, string newSignalName, int flags)
        {
            object local_errorMessages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ChangeSignal(out local_errorMessages, targetId, oldSignalName, newSignalName, flags));
            errorMessages = local_errorMessages;
            return retVal;
        }

        public int Delete(out object errorMessages, int targetId, int flags)
        {
            object local_errorMessages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Delete(out local_errorMessages, targetId, flags));
            errorMessages = local_errorMessages;
            return retVal;
        }

        public int DeleteAndReconnect(out object errorMessages, int targetId, int flags)
        {
            object local_errorMessages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeleteAndReconnect(out local_errorMessages, targetId, flags));
            errorMessages = local_errorMessages;
            return retVal;
        }

        public int DeleteAttribute(out object errorMessages, int targetId, string attributeName, string value, int objectType1, int objectType2, string name, int flags)
        {
            object local_errorMessages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(out local_errorMessages, targetId, attributeName, value, objectType1, objectType2, name, flags));
            errorMessages = local_errorMessages;
            return retVal;
        }

        public int DeleteDevice(out object errorMessages, int devid, int forced, int flags)
        {
            object local_errorMessages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeleteDevice(out local_errorMessages, devid, forced, flags));
            errorMessages = local_errorMessages;
            return retVal;
        }

        public int DeleteSheet(out object errorMessages, int sheetid, int flags)
        {
            object local_errorMessages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeleteSheet(out local_errorMessages, sheetid, flags));
            errorMessages = local_errorMessages;
            return retVal;
        }

        public int SwapSymbol(out object errorMessages, int targetId, string newPin, string NewSymbol, int flags)
        {
            object local_errorMessages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SwapSymbol(out local_errorMessages, targetId, newPin, NewSymbol, flags));
            errorMessages = local_errorMessages;
            return retVal;
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

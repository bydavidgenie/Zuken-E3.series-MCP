using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
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

        public int AddAttribute(out object messages, int targetId, string attributeName, string value, int objectType1, int objectType2, string name, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AddAttribute(out local_messages, targetId, attributeName, value, objectType1, objectType2, name, flags));
            messages = local_messages;
            return retVal;
        }

        public int ChangeAttribute(out object messages, int targetId, string attributeName, string oldValue, string newValue, int objectType1, int objectType2, string name, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ChangeAttribute(out local_messages, targetId, attributeName, oldValue, newValue, objectType1, objectType2, name, flags));
            messages = local_messages;
            return retVal;
        }

        public int ChangeComponent(out object messages, int targetId, string NewComponent, string oldComponent, string newVersion, string oldVersion, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ChangeComponent(out local_messages, targetId, NewComponent, oldComponent, newVersion, oldVersion, flags));
            messages = local_messages;
            return retVal;
        }

        public int ChangeDeviceDesignation(out object messages, int targetId, int objectType1, int objectType2, string newDeviceDesignation, string newHigherLevelAssignment, string newLocation, string oldDeviceDesignation, string oldHigherLevelAssignment, string oldLocation, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ChangeDeviceDesignation(out local_messages, targetId, objectType1, objectType2, newDeviceDesignation, newHigherLevelAssignment, newLocation, oldDeviceDesignation, oldHigherLevelAssignment, oldLocation, flags));
            messages = local_messages;
            return retVal;
        }

        public int ChangeDeviceDesignationOfSymbols(out object messages, int targetId, string newDeviceDesignation, string newHigherLevelAssignment, string newLocation, string oldDeviceDesignation, string oldHigherLevelAssignment, string oldLocation, string name, string NewSymbol, int viewnumber, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ChangeDeviceDesignationOfSymbols(out local_messages, targetId, newDeviceDesignation, newHigherLevelAssignment, newLocation, oldDeviceDesignation, oldHigherLevelAssignment, oldLocation, name, NewSymbol, viewnumber, flags));
            messages = local_messages;
            return retVal;
        }

        public int ChangeSignal(out object messages, int targetId, string oldSignalName, string newSignalName, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ChangeSignal(out local_messages, targetId, oldSignalName, newSignalName, flags));
            messages = local_messages;
            return retVal;
        }

        public int ChangeSymbolName(out object messages, int targetId, string newname, string newCharacteristic, string oldname, string oldCharacteristic, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ChangeSymbolName(out local_messages, targetId, newname, newCharacteristic, oldname, oldCharacteristic, flags));
            messages = local_messages;
            return retVal;
        }

        public int ChangeText(out object messages, int targetId, string oldText, string newtext, int texttype, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ChangeText(out local_messages, targetId, oldText, newtext, texttype, flags));
            messages = local_messages;
            return retVal;
        }

        public int Delete(out object messages, int targetId, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Delete(out local_messages, targetId, flags));
            messages = local_messages;
            return retVal;
        }

        public int DeleteAndReconnect(out object messages, int targetId, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeleteAndReconnect(out local_messages, targetId, flags));
            messages = local_messages;
            return retVal;
        }

        public int DeleteAttribute(out object messages, int targetId, string attributeName, string value, int objectType1, int objectType2, string name, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(out local_messages, targetId, attributeName, value, objectType1, objectType2, name, flags));
            messages = local_messages;
            return retVal;
        }

        public int DeleteDevice(out object messages, int devid, int forced, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeleteDevice(out local_messages, devid, forced, flags));
            messages = local_messages;
            return retVal;
        }

        public int DeleteSheet(out object messages, int sheetid, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeleteSheet(out local_messages, sheetid, flags));
            messages = local_messages;
            return retVal;
        }

        public int Move(out object messages, int targetId, double x, double y, string sheet_name, string sheet_assignment, string sheet_location, string target_symbol_designation, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Move(out local_messages, targetId, x, y, sheet_name, sheet_assignment, sheet_location, target_symbol_designation, flags));
            messages = local_messages;
            return retVal;
        }

        public int SwapSymbol(out object messages, int targetId, string newPin, string NewSymbol, int flags)
        {
            object local_messages = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SwapSymbol(out local_messages, targetId, newPin, NewSymbol, flags));
            messages = local_messages;
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

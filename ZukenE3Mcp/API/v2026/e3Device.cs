using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Device : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Device _raw;
        private bool _disposed;

        public e3Device(Zuken.E3.Interop.e3Device raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Device RawObject => _raw;

        public int AddAttibuteValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttibuteValue(name, value));
        }

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int AddToAssembly(ref object ids, int position, int before)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AddToAssembly(ref local_ids, position, before));
            ids = local_ids;
            return retVal;
        }

        public int AddToInstallationSpace(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AddToInstallationSpace(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int AddToOverbraid(ref object ids, int position, int before)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AddToOverbraid(ref local_ids, position, before));
            ids = local_ids;
            return retVal;
        }

        public int AssignAsVariantInstance(int devid, string expression)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AssignAsVariantInstance(devid, expression));
        }

        public int AssignFunctionalUnits(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AssignFunctionalUnits(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int AssignFunctionalUnitsDynamic(string name, string assignment, string location, int type, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AssignFunctionalUnitsDynamic(name, assignment, location, type, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int AutosolveTerminalstrip()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AutosolveTerminalstrip());
        }

        public int BridgeTerminals(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.BridgeTerminals(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int ChangeAssignedOptionExpression(string oldval, string newval, int oldflags, int newflags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ChangeAssignedOptionExpression(oldval, newval, oldflags, newflags));
        }

        public int Create(string name, string assignment, string location, string comp, string vers, int after)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name, assignment, location, comp, vers, after));
        }

        public int Create2DView(int modi, string name, string symbol, int position, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create2DView(modi, name, symbol, position, before));
        }

        public int Create2DViewEx(int modi, string name, string symbol, int position, int before, int shtId, double xmin, double ymin, double xmax, double ymax, double scale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create2DViewEx(modi, name, symbol, position, before, shtId, xmin, ymin, xmax, ymax, scale));
        }

        public int Create2DViewOfSlots(int modi, string name, string symbol, ref object slotslist, int position, int before, int shtId, double xmin, double ymin, double xmax, double ymax, double scale)
        {
            object local_slotslist = slotslist;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Create2DViewOfSlots(modi, name, symbol, ref local_slotslist, position, before, shtId, xmin, ymin, xmax, ymax, scale));
            slotslist = local_slotslist;
            return retVal;
        }

        public int CreateAssembly(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateAssembly(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int CreateBlock(string name, string assignment, string location, string cmpname, string version, string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateBlock(name, assignment, location, cmpname, version, filename));
        }

        public int CreateCable(string name, string assignment, string location)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateCable(name, assignment, location));
        }

        public int CreateCableDuct(string name, string assignment, string location, double xlen, double ywid, double zhgt, string templ)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateCableDuct(name, assignment, location, xlen, ywid, zhgt, templ));
        }

        public int CreateCableDuctEx(string name, string assignment, string location, double xlen, double ywid, double zhgt, string templ, int flags, double combwidth)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateCableDuctEx(name, assignment, location, xlen, ywid, zhgt, templ, flags, combwidth));
        }

        public int CreateConnector(string name, string assignment, string location)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateConnector(name, assignment, location));
        }

        public int CreateConnectorOnBlock(int blkid, string name, string assignment, string location)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateConnectorOnBlock(blkid, name, assignment, location));
        }

        public int CreateConnectorOnBlockEx(int blkid, string name, string assignment, string location, string cmpname, string version)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateConnectorOnBlockEx(blkid, name, assignment, location, cmpname, version));
        }

        public int CreateDeviceOnBlock(int blkid, string name, string assignment, string location, string comp, string vers, int after)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateDeviceOnBlock(blkid, name, assignment, location, comp, vers, after));
        }

        public int CreateFormboard(int from, int shtId, int blockid, string databaseDeviceView)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateFormboard(from, shtId, blockid, databaseDeviceView));
        }

        public int CreateFunctionalDesignBlock(string name, string assignment, string location, string cmpname, string version)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateFunctionalDesignBlock(name, assignment, location, cmpname, version));
        }

        public int CreateInstance(int vari)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateInstance(vari));
        }

        public int CreateMount(string name, string assignment, string location, double xlen, double ywid, double zhgt, string slotdes, string templ)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateMount(name, assignment, location, xlen, ywid, zhgt, slotdes, templ));
        }

        public int CreateOverbraid(string name, string assignment, string location, string cmpname, string version)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateOverbraid(name, assignment, location, cmpname, version));
        }

        public int CreateView(int from, int level, int blockid, string databaseDeviceView)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateView(from, level, blockid, databaseDeviceView));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DeleteEndAttribute(int which, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteEndAttribute(which, name));
        }

        public int DeleteForced()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteForced());
        }

        public int DeleteInstance()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteInstance());
        }

        public int DeleteInstanceForced()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteInstanceForced());
        }

        public int FindPanelPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FindPanelPath());
        }

        public int Get3DTransparency()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Get3DTransparency());
        }

        public int GetAllCoreCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAllCoreCount());
        }

        public int GetAllCoreIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllCoreIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetAllPinCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAllPinCount());
        }

        public int GetAllPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetAnyCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAnyCount());
        }

        public int GetAnyIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAnyIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetAssemblyId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAssemblyId());
        }

        public int GetAssignedBusbarPins(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAssignedBusbarPins(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetAssignedOptionExpressions(ref object expressions, int Term)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAssignedOptionExpressions(ref local_expressions, Term));
            expressions = local_expressions;
            return retVal;
        }

        public int GetAssignedOptionExpressionsEx(ref object expressions, int Term)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAssignedOptionExpressionsEx(ref local_expressions, Term));
            expressions = local_expressions;
            return retVal;
        }

        public int GetAssignedOptionExpressionsWithFlags(ref object expressions, int Term)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAssignedOptionExpressionsWithFlags(ref local_expressions, Term));
            expressions = local_expressions;
            return retVal;
        }

        public int GetAssignedOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAssignedOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetAssignment()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAssignment());
        }

        public string GetAssignmentEx(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAssignmentEx(flags));
        }

        public int GetAssignmentLockChangeable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAssignmentLockChangeable());
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

        public int GetBlockDeviceIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBlockDeviceIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetBlockId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockId());
        }

        public int GetBundleCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBundleCount());
        }

        public int GetBundleIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBundleIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCableCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCableCount());
        }

        public int GetCableDuctFillLimit()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCableDuctFillLimit());
        }

        public int GetCableDuctInletOutlet(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCableDuctInletOutlet(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCableDuctInletOutletId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCableDuctInletOutletId());
        }

        public double GetCableDuctLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCableDuctLength());
        }

        public int GetCableDuctWarningLimit()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCableDuctWarningLimit());
        }

        public int GetCableDuctWireAndCoreIds(out object coreIds, int flags)
        {
            object local_coreIds = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCableDuctWireAndCoreIds(out local_coreIds, flags));
            coreIds = local_coreIds;
            return retVal;
        }

        public int GetCableIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCableIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCarrierId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCarrierId());
        }

        public string GetComponentAttributeValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentAttributeValue(name));
        }

        public string GetComponentName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentName());
        }

        public string GetComponentVersion()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentVersion());
        }

        public int GetConnectedCableDuctIds(out object connectedCableDuctIds, int flags)
        {
            object local_connectedCableDuctIds = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectedCableDuctIds(out local_connectedCableDuctIds, flags));
            connectedCableDuctIds = local_connectedCableDuctIds;
            return retVal;
        }

        public int GetConnectorCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectorCount());
        }

        public int GetConnectorIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectorIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetConnWithInsertsId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnWithInsertsId());
        }

        public int GetCoreCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCoreCount());
        }

        public int GetCoreIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCoreIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetCounterpartComponentName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCounterpartComponentName());
        }

        public string GetCounterpartComponentVersion()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCounterpartComponentVersion());
        }

        public double GetDefinedOuterDiameter()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDefinedOuterDiameter());
        }

        public int GetDeviceCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDeviceCount());
        }

        public int GetDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetDisconnecting()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisconnecting());
        }

        public int GetDynamicModelSize(out object x, out object y, out object z)
        {
            object local_x = default;
            object local_y = default;
            object local_z = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDynamicModelSize(out local_x, out local_y, out local_z));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int GetEndAttributeCount(int which)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetEndAttributeCount(which));
        }

        public int GetEndAttributeIds(int which, ref object ids, string attnam)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetEndAttributeIds(which, ref local_ids, attnam));
            ids = local_ids;
            return retVal;
        }

        public string GetEndAttributeValue(int which, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetEndAttributeValue(which, name));
        }

        public string GetFileName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFileName());
        }

        public int GetFormboardIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetFormboardIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetFormboardSheetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFormboardSheetId());
        }

        public int GetFunctionalBlockSymbolIDs(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetFunctionalBlockSymbolIDs(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetFunctionalUnitIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetFunctionalUnitIds(ref local_ids));
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

        public int GetInheritName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInheritName());
        }

        public int GetInstallationSpace()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInstallationSpace());
        }

        public int GetInterruptSignalFlow()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInterruptSignalFlow());
        }

        public int GetJustificationArea(out object z)
        {
            object local_z = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetJustificationArea(out local_z));
            z = local_z;
            return retVal;
        }

        public int GetJustificationLine(out object y, out object z)
        {
            object local_y = default;
            object local_z = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetJustificationLine(out local_y, out local_z));
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int GetJustificationPoint(out object x, out object y, out object z)
        {
            object local_x = default;
            object local_y = default;
            object local_z = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetJustificationPoint(out local_x, out local_y, out local_z));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public string GetLocation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocation());
        }

        public string GetLocationEx(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocationEx(flags));
        }

        public int GetLocationLockChangeable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocationLockChangeable());
        }

        public string GetMasterPinName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMasterPinName());
        }

        public string GetModelCharacteristic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetModelCharacteristic());
        }

        public string GetModelName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetModelName());
        }

        public int GetMountedCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMountedCount());
        }

        public int GetMountedIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetMountedIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetMountedSlotIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetMountedSlotIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public double GetMountLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMountLength());
        }

        public int GetMountTypes(ref object types)
        {
            object local_types = types;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetMountTypes(ref local_types));
            types = local_types;
            return retVal;
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public string GetNameEx(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNameEx(flags));
        }

        public int GetNameLockChangeable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNameLockChangeable());
        }

        public int GetNetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNoconnPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNoconnPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOriginalId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOriginalId());
        }

        public double GetOuterDiameter()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOuterDiameter());
        }

        public int GetOutlineCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOutlineCount());
        }

        public int GetOutlineIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOutlineIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOverbraidId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOverbraidId());
        }

        public int GetOverbraidIdEx()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOverbraidIdEx());
        }

        public int GetPanelFreePlacement()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPanelFreePlacement());
        }

        public int GetPanelLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPanelLevel());
        }

        public int GetPanelLocation(out object x, out object y, out object z, out object rot, ref object pivot)
        {
            object local_x = default;
            object local_y = default;
            object local_z = default;
            object local_rot = default;
            object local_pivot = pivot;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPanelLocation(out local_x, out local_y, out local_z, out local_rot, ref local_pivot));
            x = local_x;
            y = local_y;
            z = local_z;
            rot = local_rot;
            pivot = local_pivot;
            return retVal;
        }

        public int GetPanelLocationXYZEulerAngles(out object x, out object y, out object z, out object xrot, out object yrot, out object zrot)
        {
            object local_x = default;
            object local_y = default;
            object local_z = default;
            object local_xrot = default;
            object local_yrot = default;
            object local_zrot = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPanelLocationXYZEulerAngles(out local_x, out local_y, out local_z, out local_xrot, out local_yrot, out local_zrot));
            x = local_x;
            y = local_y;
            z = local_z;
            xrot = local_xrot;
            yrot = local_yrot;
            zrot = local_zrot;
            return retVal;
        }

        public int GetPanelPositionLock()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPanelPositionLock());
        }

        public double GetPhysicalLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalLength());
        }

        public int GetPinCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinCount());
        }

        public int GetPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetReferenceType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetReferenceType());
        }

        public int GetRootAssemblyId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRootAssemblyId());
        }

        public int GetRootOverbraidId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRootOverbraidId());
        }

        public int GetSchematicTypes(ref object types)
        {
            object local_types = types;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSchematicTypes(ref local_types));
            types = local_types;
            return retVal;
        }

        public int GetSealedState()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSealedState());
        }

        public int GetSlotIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSlotIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSpaceRequirement(int flags, out object lowerleft, out object upperright, out object origin)
        {
            object local_lowerleft = default;
            object local_upperright = default;
            object local_origin = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSpaceRequirement(flags, out local_lowerleft, out local_upperright, out local_origin));
            lowerleft = local_lowerleft;
            upperright = local_upperright;
            origin = local_origin;
            return retVal;
        }

        public int GetSpaceRequirementOnCarrier(out object lowerleft, out object upperright, out object origin, int carrierid)
        {
            object local_lowerleft = default;
            object local_upperright = default;
            object local_origin = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSpaceRequirementOnCarrier(out local_lowerleft, out local_upperright, out local_origin, carrierid));
            lowerleft = local_lowerleft;
            upperright = local_upperright;
            origin = local_origin;
            return retVal;
        }

        public int GetStateId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetStateId());
        }

        public int GetSupplyId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSupplyId());
        }

        public int GetSupplyIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSupplyIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSupplyPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSupplyPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSymbolCount(int get_mode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolCount(get_mode));
        }

        public int GetSymbolIds(ref object ids, int get_mode)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolIds(ref local_ids, get_mode));
            ids = local_ids;
            return retVal;
        }

        public int GetTableSymbolId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTableSymbolId());
        }

        public int GetTerminalBlockId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTerminalBlockId());
        }

        public int GetTerminalPlanSettings(ref object parameters)
        {
            object local_parameters = parameters;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTerminalPlanSettings(ref local_parameters));
            parameters = local_parameters;
            return retVal;
        }

        public int GetTerminalPlanSheetIds(ref object shtids)
        {
            object local_shtids = shtids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTerminalPlanSheetIds(ref local_shtids));
            shtids = local_shtids;
            return retVal;
        }

        public int GetTerminalType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTerminalType());
        }

        public int GetValidComponentCodes(ref object names)
        {
            object local_names = names;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetValidComponentCodes(ref local_names));
            names = local_names;
            return retVal;
        }

        public int GetValidComponentCodesEx(ref object names, int flags)
        {
            object local_names = names;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetValidComponentCodesEx(ref local_names, flags));
            names = local_names;
            return retVal;
        }

        public int GetValidModelCharacteristics(ref object characteristics)
        {
            object local_characteristics = characteristics;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetValidModelCharacteristics(ref local_characteristics));
            characteristics = local_characteristics;
            return retVal;
        }

        public int GetVariantObjectProperties(int iObjectType, string sAttributeName, ref object arr)
        {
            object local_arr = arr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetVariantObjectProperties(iObjectType, sAttributeName, ref local_arr));
            arr = local_arr;
            return retVal;
        }

        public int GetViewCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetViewCount());
        }

        public int GetViewIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetViewIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetViewNumber()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetViewNumber());
        }

        public int Has2DView()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Has2DView());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int HasEndAttribute(int which, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasEndAttribute(which, name));
        }

        public int HasNoconn()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasNoconn());
        }

        public int HasPassWirePins()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasPassWirePins());
        }

        public int InsertTerminalPlan(ref object parameters)
        {
            object local_parameters = parameters;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.InsertTerminalPlan(ref local_parameters));
            parameters = local_parameters;
            return retVal;
        }

        public int IsAssembly()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsAssembly());
        }

        public int IsAssemblyPart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsAssemblyPart());
        }

        public int IsAssignmentLockChangeable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsAssignmentLockChangeable());
        }

        public int IsBlock()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBlock());
        }

        public int IsBusbar()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBusbar());
        }

        public int IsCable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCable());
        }

        public int IsCableDuct()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCableDuct());
        }

        public int IsCableDuctInletOutlet()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCableDuctInletOutlet());
        }

        public int IsCableDuctInletOutletPart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCableDuctInletOutletPart());
        }

        public int IsClipboardPart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsClipboardPart());
        }

        public int IsConnector()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsConnector());
        }

        public int IsConnWithInserts()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsConnWithInserts());
        }

        public int IsConnWithInsertsPart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsConnWithInsertsPart());
        }

        public int IsDevice()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsDevice());
        }

        public int IsDynamicModel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsDynamicModel());
        }

        public int IsFeedThroughConnector()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFeedThroughConnector());
        }

        public int IsFormboard()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFormboard());
        }

        public int IsFunctionalBlock()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFunctionalBlock());
        }

        public int IsFunctionalDesignBlock()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFunctionalDesignBlock());
        }

        public int IsHarness()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsHarness());
        }

        public int IsHierarchicalBlock()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsHierarchicalBlock());
        }

        public int IsHose()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsHose());
        }

        public int IsInstallationSpace()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsInstallationSpace());
        }

        public int IsLocationLockChangeable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLocationLockChangeable());
        }

        public int IsLocked()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLocked());
        }

        public int IsLockedByAccessControl()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLockedByAccessControl());
        }

        public int IsLockPurgeUnused()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLockPurgeUnused());
        }

        public int IsModule()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsModule());
        }

        public int IsMount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsMount());
        }

        public int IsNameLockChangeable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsNameLockChangeable());
        }

        public int IsOverbraid()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsOverbraid());
        }

        public int IsOverbraidPart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsOverbraidPart());
        }

        public int IsPinTerminalSymbolsUsed()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPinTerminalSymbolsUsed());
        }

        public int IsPlacedInPanel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPlacedInPanel());
        }

        public int IsPreventedAgainstPhysicalChangesOfCores()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPreventedAgainstPhysicalChangesOfCores());
        }

        public int IsTerminal()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsTerminal());
        }

        public int IsTerminalBlock()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsTerminalBlock());
        }

        public int IsTube()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsTube());
        }

        public int IsView()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsView());
        }

        public int IsWireGroup()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsWireGroup());
        }

        public int Jump()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Jump());
        }

        public int LoadAndCreate(string comp, string vers, int type)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadAndCreate(comp, vers, type));
        }

        public int LoadAndPlaceComponent(string name, string assignment, string location, string comp, string vers, string wirename, int after, int options)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadAndPlaceComponent(name, assignment, location, comp, vers, wirename, after, options));
        }

        public int LockObject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LockObject());
        }

        public int MergeHarnesses(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.MergeHarnesses(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int MergeTerminals(ref object ids, string CompName, int mergeterminalscontinuously)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.MergeTerminals(ref local_ids, CompName, mergeterminalscontinuously));
            ids = local_ids;
            return retVal;
        }

        public int PlaceModelViewAsGraphic(int sheetid, double x, double y, string rotation, int modelview, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceModelViewAsGraphic(sheetid, x, y, rotation, modelview, flags));
        }

        public int PlaceOnAreaSlot(int slotid, double x, double y, double rotation, int pivot, int combined, ref object collisionids)
        {
            object local_collisionids = collisionids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PlaceOnAreaSlot(slotid, x, y, rotation, pivot, combined, ref local_collisionids));
            collisionids = local_collisionids;
            return retVal;
        }

        public int PlaceOnLineSlot(int slotid, double x, double rotation, int combined, ref object collisionids)
        {
            object local_collisionids = collisionids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PlaceOnLineSlot(slotid, x, rotation, combined, ref local_collisionids));
            collisionids = local_collisionids;
            return retVal;
        }

        public int PlaceOnPointSlot(int slotid, double rotation, int pivot, int combined, ref object collisionids)
        {
            object local_collisionids = collisionids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PlaceOnPointSlot(slotid, rotation, pivot, combined, ref local_collisionids));
            collisionids = local_collisionids;
            return retVal;
        }

        public int PlugWith(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlugWith(id));
        }

        public int PlugWithMatingPins(ref object deviceIds)
        {
            object local_deviceIds = deviceIds;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PlugWithMatingPins(ref local_deviceIds));
            deviceIds = local_deviceIds;
            return retVal;
        }

        public int RemoveFromAssembly(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.RemoveFromAssembly(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int RemoveFromInstallationSpace(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.RemoveFromInstallationSpace(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int RemoveFromOverbraid(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.RemoveFromOverbraid(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int Search(string name, string assignment, string location)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(name, assignment, location));
        }

        public int SearchAll(string name, string assignment, string location, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SearchAll(name, assignment, location, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int Set3DTransparency(int mode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Set3DTransparency(mode));
        }

        public int SetAssignedOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetAssignedOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int SetAssignment(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAssignment(name));
        }

        public int SetAssignmentLockChangeable(int lockchangeable)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAssignmentLockChangeable(lockchangeable));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetAttributeValueVariant(string name, string value, int copy, string VariantExpression)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValueVariant(name, value, copy, VariantExpression));
        }

        public int SetCableDuctFillLimit(int percentage)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCableDuctFillLimit(percentage));
        }

        public int SetCableDuctLength(double newlen)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCableDuctLength(newlen));
        }

        public int SetCableDuctWarningLimit(int percentage)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCableDuctWarningLimit(percentage));
        }

        public int SetCompleteName(string name, string assignment, string location, int onlygiven)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCompleteName(name, assignment, location, onlygiven));
        }

        public int SetComponentName(string name, string version)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetComponentName(name, version));
        }

        public int SetDisconnecting(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisconnecting(onoff));
        }

        public int SetDynamicModelSize(ref object x, ref object y, ref object z)
        {
            object local_x = x;
            object local_y = y;
            object local_z = z;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetDynamicModelSize(ref local_x, ref local_y, ref local_z));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int SetEndAttributeValue(int which, string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetEndAttributeValue(which, name, value));
        }

        public int SetFileName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFileName(name));
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

        public int SetInheritName(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetInheritName(onoff));
        }

        public int SetInterruptSignalFlow(int sigflow)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetInterruptSignalFlow(sigflow));
        }

        public int SetJustificationArea(double z, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetJustificationArea(z, flags));
        }

        public int SetJustificationLine(double y, double z, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetJustificationLine(y, z, flags));
        }

        public int SetJustificationPoint(double x, double y, double z, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetJustificationPoint(x, y, z, flags));
        }

        public int SetLocation(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLocation(name));
        }

        public int SetLocationLockChangeable(int lockchangeable)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLocationLockChangeable(lockchangeable));
        }

        public int SetLockPurgeUnused(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLockPurgeUnused(id));
        }

        public int SetMasterPinName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMasterPinName(name));
        }

        public int SetModelCharacteristic(string characteristic)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetModelCharacteristic(characteristic));
        }

        public int SetModule(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetModule(newval));
        }

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
        }

        public int SetNameLockChangeable(int lockchangeable)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetNameLockChangeable(lockchangeable));
        }

        public int SetOptionExpressions(ref object expressions)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetOptionExpressions(ref local_expressions));
            expressions = local_expressions;
            return retVal;
        }

        public int SetOptionExpressionsWithFlags(ref object expressions)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetOptionExpressionsWithFlags(ref local_expressions));
            expressions = local_expressions;
            return retVal;
        }

        public double SetOuterDiameter(double newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetOuterDiameter(newval));
        }

        public int SetPanelFreePlacement(int freeplacement)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelFreePlacement(freeplacement));
        }

        public int SetPanelLevel(int nLevel, int bChangeMounted)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelLevel(nLevel, bChangeMounted));
        }

        public int SetPanelLocation(int flags, int shti, double x, double y, double z, string rot, int use_start_z, int place_combined, int pivot)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelLocation(flags, shti, x, y, z, rot, use_start_z, place_combined, pivot));
        }

        public int SetPanelLocationEx(int flags, int shti, double x, double y, double z, string rot, int use_start_z, int place_combined, int pivot, int shift_key)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelLocationEx(flags, shti, x, y, z, rot, use_start_z, place_combined, pivot, shift_key));
        }

        public int SetPanelLocationXYZEulerAngles(int flags, int shti, double x, double y, double z, double xrot, double yrot, double zrot, int use_start_z, int place_combined, int shift_key)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelLocationXYZEulerAngles(flags, shti, x, y, z, xrot, yrot, zrot, use_start_z, place_combined, shift_key));
        }

        public int SetPanelPositionLock(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelPositionLock(onoff));
        }

        public int SetPinTerminalSymbolsUsed(int use)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPinTerminalSymbolsUsed(use));
        }

        public int SetReferenceType(int type)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetReferenceType(type));
        }

        public int SetSealedState(int type)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSealedState(type));
        }

        public int SetStateId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetStateId(id));
        }

        public int SetSupplyId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSupplyId(id));
        }

        public int SetTerminalPlanSettings(ref object parameters)
        {
            object local_parameters = parameters;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetTerminalPlanSettings(ref local_parameters));
            parameters = local_parameters;
            return retVal;
        }

        public int SetTerminalSequence(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetTerminalSequence(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int SetViewNumber(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetViewNumber(id));
        }

        public int Sort(int Sort)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Sort(Sort));
        }

        public int SortHarness(ref object ids, int postion, int options)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SortHarness(ref local_ids, postion, options));
            ids = local_ids;
            return retVal;
        }

        public int SortTerminals(int method, int sub_method, string sort_file)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SortTerminals(method, sub_method, sort_file));
        }

        public int UnlockObject(string password)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnlockObject(password));
        }

        public int UnplacePanel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnplacePanel());
        }

        public int UnplugFromMatingPins(ref object deviceIds)
        {
            object local_deviceIds = deviceIds;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.UnplugFromMatingPins(ref local_deviceIds));
            deviceIds = local_deviceIds;
            return retVal;
        }

        public int UpdateDisconnecting(int options, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.UpdateDisconnecting(options, ref local_ids));
            ids = local_ids;
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

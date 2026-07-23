using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3Pin : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Pin _raw;
        private bool _disposed;

        public e3Pin(Zuken.E3.Interop.e3Pin raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Pin RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int AddDefaultWire(IntPtr wiregroup, IntPtr wirename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddDefaultWire(wiregroup, wirename));
        }

        public int AddDefaultWireEx(string wiregroup, string wirename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddDefaultWireEx(wiregroup, wirename));
        }

        public int AddEndAttributeValue(int which, string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddEndAttributeValue(which, name, value));
        }

        public int AddPinsToConnector(ref object pinidarray, string name, string assignment, string location)
        {
            object local_pinidarray = pinidarray;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AddPinsToConnector(ref local_pinidarray, name, assignment, location));
            pinidarray = local_pinidarray;
            return retVal;
        }

        public int AssignBusbar(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AssignBusbar(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int AssignTo(ref object pinids)
        {
            object local_pinids = pinids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AssignTo(ref local_pinids));
            pinids = local_pinids;
            return retVal;
        }

        public int CalculateCavityPartsForWires(ref object wirids, ref object fittinglst, ref object wireseallst)
        {
            object local_wirids = wirids;
            object local_fittinglst = fittinglst;
            object local_wireseallst = wireseallst;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CalculateCavityPartsForWires(ref local_wirids, ref local_fittinglst, ref local_wireseallst));
            wirids = local_wirids;
            fittinglst = local_fittinglst;
            wireseallst = local_wireseallst;
            return retVal;
        }

        public int CalculateFittingForWires(ref object wirids, ref object fittinglst)
        {
            object local_wirids = wirids;
            object local_fittinglst = fittinglst;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CalculateFittingForWires(ref local_wirids, ref local_fittinglst));
            wirids = local_wirids;
            fittinglst = local_fittinglst;
            return retVal;
        }

        public int ChangeAssignedOptionExpression(string oldval, string newval, int oldflags, int newflags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ChangeAssignedOptionExpression(oldval, newval, oldflags, newflags));
        }

        public int Create(string name, int devi, int pini, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name, devi, pini, before));
        }

        public int CreateNewConnectorForPins(ref object pinidarray, string name, string assignment, string location)
        {
            object local_pinidarray = pinidarray;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateNewConnectorForPins(ref local_pinidarray, name, assignment, location));
            pinidarray = local_pinidarray;
            return retVal;
        }

        public int CreateWire(string name, string cabtyp, string wirnam, int devi, int pini, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateWire(name, cabtyp, wirnam, devi, pini, before));
        }

        public int DeAssignBusbar(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeAssignBusbar(flags));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DeleteDefaultWire(IntPtr wiregroup, IntPtr wirename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteDefaultWire(wiregroup, wirename));
        }

        public int DeleteDefaultWireEx(string wiregroup, string wirename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteDefaultWireEx(wiregroup, wirename));
        }

        public int DeleteEndAttribute(int which, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteEndAttribute(which, name));
        }

        public int DeleteEx(ref object list, int forced)
        {
            object local_list = list;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeleteEx(ref local_list, forced));
            list = local_list;
            return retVal;
        }

        public int DeleteForced()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteForced());
        }

        public int DeletePanelPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeletePanelPath());
        }

        public int FindPanelPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FindPanelPath());
        }

        public int GenerateNewWireNames(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GenerateNewWireNames(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int Get3DTransparency()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Get3DTransparency());
        }

        public int GetAllNetSegmentIds(int flags, out object views, out object types, out object viewcounts, out object ids)
        {
            object local_views = default;
            object local_types = default;
            object local_viewcounts = default;
            object local_ids = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllNetSegmentIds(flags, out local_views, out local_types, out local_viewcounts, out local_ids));
            views = local_views;
            types = local_types;
            viewcounts = local_viewcounts;
            ids = local_ids;
            return retVal;
        }

        public int GetAllNetSegmentPaths(ref object ids, int pin1i, int pin2i)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllNetSegmentPaths(ref local_ids, pin1i, pin2i));
            ids = local_ids;
            return retVal;
        }

        public int GetAllowMultipleWireCrimps()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAllowMultipleWireCrimps());
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

        public int GetBlockConnectionNumber()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockConnectionNumber());
        }

        public int GetCableDuctIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCableDuctIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCavityPartIds(out object ids, int type)
        {
            object local_ids = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCavityPartIds(out local_ids, type));
            ids = local_ids;
            return retVal;
        }

        public int GetCavityPartsFromPinByCore(int coreid, out object cavityParts, int type)
        {
            object local_cavityParts = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCavityPartsFromPinByCore(coreid, out local_cavityParts, type));
            cavityParts = local_cavityParts;
            return retVal;
        }

        public int GetCCT()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCCT());
        }

        public int GetColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetColour());
        }

        public string GetColourDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetColourDescription());
        }

        public string GetColourDescriptionByInstallationLanguage(int installationLanguage, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetColourDescriptionByInstallationLanguage(installationLanguage, flags));
        }

        public string GetComponentAttributeValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentAttributeValue(name));
        }

        public int GetComponentPinId(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentPinId(flags));
        }

        public int GetConnectedNodeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectedNodeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetConnectedPinId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectedPinId());
        }

        public int GetConnectedPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectedPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetConnectionType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectionType());
        }

        public string GetConnectionTypeDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectionTypeDescription());
        }

        public int GetCoreChangeIds(ref object ids, ref object optids)
        {
            object local_ids = ids;
            object local_optids = optids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCoreChangeIds(ref local_ids, ref local_optids));
            ids = local_ids;
            optids = local_optids;
            return retVal;
        }

        public string GetCoreCost()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCoreCost());
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

        public double GetCoreManufacturingLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCoreManufacturingLength());
        }

        public double GetCoreWeight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCoreWeight());
        }

        public string GetCounterpart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCounterpart());
        }

        public double GetCrossSection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCrossSection());
        }

        public string GetCrossSectionDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCrossSectionDescription());
        }

        public int GetDefaultWires(ref object wiregroups, ref object wirenames)
        {
            object local_wiregroups = wiregroups;
            object local_wirenames = wirenames;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDefaultWires(ref local_wiregroups, ref local_wirenames));
            wiregroups = local_wiregroups;
            wirenames = local_wirenames;
            return retVal;
        }

        public double GetDefinedOuterDiameter()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDefinedOuterDiameter());
        }

        public int GetDestinationCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDestinationCount());
        }

        public int GetDestinationIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDestinationIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetDevicePinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDevicePinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public double GetDiameter()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDiameter());
        }

        public string GetDiameterDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDiameterDescription());
        }

        public int GetDisableAutomaticFittingSelection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisableAutomaticFittingSelection());
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

        public int GetEndCavityPartIds(int which, ref object cavities, int type)
        {
            object local_cavities = cavities;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetEndCavityPartIds(which, ref local_cavities, type));
            cavities = local_cavities;
            return retVal;
        }

        public int GetEndPinId(int which, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetEndPinId(which, flags));
        }

        public int GetExchangeableID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetExchangeableID());
        }

        public string GetExternSignalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetExternSignalName());
        }

        public string GetFitting()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFitting());
        }

        public int GetFittingIds(ref object ids, ref object optids)
        {
            object local_ids = ids;
            object local_optids = optids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetFittingIds(ref local_ids, ref local_optids));
            ids = local_ids;
            optids = local_optids;
            return retVal;
        }

        public int GetFunc()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFunc());
        }

        public int GetFunctionalPortID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFunctionalPortID());
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

        public string GetInternalColourDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalColourDescription());
        }

        public int GetInterruptSignalFlow()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInterruptSignalFlow());
        }

        public double GetLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLength());
        }

        public int GetLocking()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocking());
        }

        public int GetLogicalEquivalenceID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLogicalEquivalenceID());
        }

        public int GetLogicalEquivalencePinIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLogicalEquivalencePinIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetLossAngle(ref object lossangle)
        {
            object local_lossangle = lossangle;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLossAngle(ref local_lossangle));
            lossangle = local_lossangle;
            return retVal;
        }

        public int GetMaterial()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMaterial());
        }

        public string GetMaterialDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMaterialDescription());
        }

        public int GetMergeSegment()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMergeSegment());
        }

        public int GetMultipleWireCrimps()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMultipleWireCrimps());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetNameEquivalenceID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNameEquivalenceID());
        }

        public int GetNetSegmentCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNetSegmentCount());
        }

        public int GetNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNetSegmentPath(ref object ids, int pin1i, int pin2i)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNetSegmentPath(ref local_ids, pin1i, pin2i));
            ids = local_ids;
            return retVal;
        }

        public int GetNodeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNodeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNodeType(ref object type)
        {
            object local_type = type;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNodeType(ref local_type));
            type = local_type;
            return retVal;
        }

        public int GetNumberOfWindings()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNumberOfWindings());
        }

        public int GetOneTerminalPerCore()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOneTerminalPerCore());
        }

        public string GetOriginalCoreName(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOriginalCoreName(flags));
        }

        public int GetOriginalId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOriginalId());
        }

        public double GetOuterDiameter()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOuterDiameter());
        }

        public int GetOverbraidId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOverbraidId());
        }

        public int GetOverbraidIdEx()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOverbraidIdEx());
        }

        public int GetPanelLocation(ref object x, ref object y, ref object z)
        {
            object local_x = x;
            object local_y = y;
            object local_z = z;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPanelLocation(ref local_x, ref local_y, ref local_z));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int GetPanelNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPanelNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetPanelPath(ref object xarr, ref object yarr, ref object zarr)
        {
            object local_xarr = xarr;
            object local_yarr = yarr;
            object local_zarr = zarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPanelPath(ref local_xarr, ref local_yarr, ref local_zarr));
            xarr = local_xarr;
            yarr = local_yarr;
            zarr = local_zarr;
            return retVal;
        }

        public int GetPassPins(ref object ids, ref object ends, ref object ende)
        {
            object local_ids = ids;
            object local_ends = ends;
            object local_ende = ende;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPassPins(ref local_ids, ref local_ends, ref local_ende));
            ids = local_ids;
            ends = local_ends;
            ende = local_ende;
            return retVal;
        }

        public int GetPassWires(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPassWires(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetPhysicalConnectionDirection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalConnectionDirection());
        }

        public int GetPhysicalConnectionType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalConnectionType());
        }

        public string GetPhysicalConnectionTypeDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalConnectionTypeDescription());
        }

        public int GetPhysicalID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalID());
        }

        public int GetPhysicalMaxConnections()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalMaxConnections());
        }

        public double GetPhysicalMaxCrossSection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalMaxCrossSection());
        }

        public double GetPhysicalMinCrossSection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalMinCrossSection());
        }

        public int GetPhysicalPosition(ref object x, ref object y, ref object z)
        {
            object local_x = x;
            object local_y = y;
            object local_z = z;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalPosition(ref local_x, ref local_y, ref local_z));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public double GetPhysicalTotalMaxCrossSection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPhysicalTotalMaxCrossSection());
        }

        public int GetPinGender()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinGender());
        }

        public int GetPinIndex()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinIndex());
        }

        public int GetPlugStatus()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPlugStatus());
        }

        public string GetPortName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPortName());
        }

        public int GetRelativePermittivity(ref object relativepermittivity)
        {
            object local_relativepermittivity = relativepermittivity;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetRelativePermittivity(ref local_relativepermittivity));
            relativepermittivity = local_relativepermittivity;
            return retVal;
        }

        public int GetRootOverbraidId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRootOverbraidId());
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

        public int GetSchemaLocation(ref object x, ref object y, ref object grid, ref object column_value, ref object row_value)
        {
            object local_x = x;
            object local_y = y;
            object local_grid = grid;
            object local_column_value = column_value;
            object local_row_value = row_value;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSchemaLocation(ref local_x, ref local_y, ref local_grid, ref local_column_value, ref local_row_value));
            x = local_x;
            y = local_y;
            grid = local_grid;
            column_value = local_column_value;
            row_value = local_row_value;
            return retVal;
        }

        public int GetSchematicEndPinId(int which)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSchematicEndPinId(which));
        }

        public int GetSequenceNumber()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSequenceNumber());
        }

        public string GetSignalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalName());
        }

        public int GetSupplyInfo(ref object supid, ref object signum, ref object signam)
        {
            object local_supid = supid;
            object local_signum = signum;
            object local_signam = signam;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSupplyInfo(ref local_supid, ref local_signum, ref local_signam));
            supid = local_supid;
            signum = local_signum;
            signam = local_signam;
            return retVal;
        }

        public string GetSymbolName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolName());
        }

        public int GetTemplateSymbolId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTemplateSymbolId());
        }

        public int GetTemplateSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTemplateSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTextCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTextCount());
        }

        public int GetTextIds(ref object ids, int txttyp, string search_string)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTextIds(ref local_ids, txttyp, search_string));
            ids = local_ids;
            return retVal;
        }

        public string GetTranslatedSignalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTranslatedSignalName());
        }

        public int GetTypeId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTypeId());
        }

        public int GetValidCounterparts(ref object strings)
        {
            object local_strings = strings;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetValidCounterparts(ref local_strings));
            strings = local_strings;
            return retVal;
        }

        public int GetValidFittings(ref object strings)
        {
            object local_strings = strings;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetValidFittings(ref local_strings));
            strings = local_strings;
            return retVal;
        }

        public int GetValidWireSeals(out object validWireSeals)
        {
            object local_validWireSeals = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetValidWireSeals(out local_validWireSeals));
            validWireSeals = local_validWireSeals;
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

        public int GetWireHoseTubeStyle(out object colour_code, out object descr_type, out object descr, out object colour, out object line_type, out object Rvalue, out object Gvalue, out object bValue, int flags)
        {
            object local_colour_code = default;
            object local_descr_type = default;
            object local_descr = default;
            object local_colour = default;
            object local_line_type = default;
            object local_Rvalue = default;
            object local_Gvalue = default;
            object local_bValue = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetWireHoseTubeStyle(out local_colour_code, out local_descr_type, out local_descr, out local_colour, out local_line_type, out local_Rvalue, out local_Gvalue, out local_bValue, flags));
            colour_code = local_colour_code;
            descr_type = local_descr_type;
            descr = local_descr;
            colour = local_colour;
            line_type = local_line_type;
            Rvalue = local_Rvalue;
            Gvalue = local_Gvalue;
            bValue = local_bValue;
            return retVal;
        }

        public string GetWireKindDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetWireKindDescription());
        }

        public int GetWireKindId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetWireKindId());
        }

        public int GetWireType(ref object comp, ref object name)
        {
            object local_comp = comp;
            object local_name = name;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetWireType(ref local_comp, ref local_name));
            comp = local_comp;
            name = local_name;
            return retVal;
        }

        public int GetWiringDirection(int pin_item, out object angle_1, out object angle_2, int carrierid, int flags)
        {
            object local_angle_1 = default;
            object local_angle_2 = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetWiringDirection(pin_item, out local_angle_1, out local_angle_2, carrierid, flags));
            angle_1 = local_angle_1;
            angle_2 = local_angle_2;
            return retVal;
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int HasDevice()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasDevice());
        }

        public int HasEndAttribute(int which, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasEndAttribute(which, name));
        }

        public int Highlight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Highlight());
        }

        public int HighlightPanelPath(int colour, double width, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HighlightPanelPath(colour, width, flags));
        }

        public int IsBackShell()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBackShell());
        }

        public int IsBusbar()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBusbar());
        }

        public int IsCoreEndLocked(int which)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCoreEndLocked(which));
        }

        public int IsCoreEndLockedPermanent()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCoreEndLockedPermanent());
        }

        public int IsExternal()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsExternal());
        }

        public int IsInternal()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsInternal());
        }

        public int IsLocked()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLocked());
        }

        public int IsLockedByAccessControl()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLockedByAccessControl());
        }

        public int IsNoconn()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsNoconn());
        }

        public int IsOffline()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsOffline());
        }

        public int IsPanelPathLocked()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPanelPathLocked());
        }

        public int IsPassWire()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPassWire());
        }

        public int IsPinView()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPinView());
        }

        public int IsRouted()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsRouted());
        }

        public int IsSupply()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsSupply());
        }

        public int IsUnmeasured(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsUnmeasured(flags));
        }

        public int IsView()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsView());
        }

        public int LockCoreEnd(int which, int @lock)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LockCoreEnd(which, @lock));
        }

        public int LockObject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LockObject());
        }

        public int LockPanelPath(int @lock)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LockPanelPath(@lock));
        }

        public int PlaceNode(int shtId, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceNode(shtId, x, y));
        }

        public int PlugWithMatingPin()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlugWithMatingPin());
        }

        public int ResetHighlightPanelPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetHighlightPanelPath());
        }

        public int ResetLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetLength());
        }

        public int Search(string name, int devi)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(name, devi));
        }

        public int Set3DTransparency(int mode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Set3DTransparency(mode));
        }

        public int SetAllowMultipleWireCrimps(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAllowMultipleWireCrimps(onoff));
        }

        public int SetAsExternal(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAsExternal(onoff));
        }

        public int SetAsInternal(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAsInternal(onoff));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetColour(int color)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetColour(color));
        }

        public int SetColourByDescription(string color)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetColourByDescription(color));
        }

        public int SetColourDescription(string color)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetColourDescription(color));
        }

        public int SetCoreChangeId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCoreChangeId(id));
        }

        public int SetCoreCost(string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCoreCost(value));
        }

        public int SetCounterpart(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCounterpart(name));
        }

        public int SetCrossSection(double crossec)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCrossSection(crossec));
        }

        public int SetCrossSectionByDescription(string description)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCrossSectionByDescription(description));
        }

        public int SetDefaultWires(ref object wiregroups, ref object wirenames)
        {
            object local_wiregroups = wiregroups;
            object local_wirenames = wirenames;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetDefaultWires(ref local_wiregroups, ref local_wirenames));
            wiregroups = local_wiregroups;
            wirenames = local_wirenames;
            return retVal;
        }

        public int SetDeviceId(int devid, int pinid, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceId(devid, pinid, before));
        }

        public int SetDisableAutomaticFittingSelection(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisableAutomaticFittingSelection(onoff));
        }

        public int SetEndAttributeValue(int which, string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetEndAttributeValue(which, name, value));
        }

        public int SetEndPinId(int which, int pini)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetEndPinId(which, pini));
        }

        public int SetFitting(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFitting(name));
        }

        public int SetFittingId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFittingId(id));
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

        public int SetInterruptSignalFlow(int sigflow)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetInterruptSignalFlow(sigflow));
        }

        public int SetLength(double length)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLength(length));
        }

        public int SetLocking(int bSet)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLocking(bSet));
        }

        public int SetLogicalEquivalenceID(int equivalenceId, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLogicalEquivalenceID(equivalenceId, flags));
        }

        public int SetMergeSegment(int bSet)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMergeSegment(bSet));
        }

        public int SetMultipleWireCrimps(int conncount)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMultipleWireCrimps(conncount));
        }

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
        }

        public int SetNameSymbol(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetNameSymbol(name));
        }

        public int SetNetSegmentPathIds(ref object netsegids)
        {
            object local_netsegids = netsegids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetNetSegmentPathIds(ref local_netsegids));
            netsegids = local_netsegids;
            return retVal;
        }

        public int SetNodeId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetNodeId(id));
        }

        public int SetOneTerminalPerCore(int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetOneTerminalPerCore(onoff));
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

        public int SetOuterDiameterByDescription(string description)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetOuterDiameterByDescription(description));
        }

        public int SetPanelPath(int pnts, ref object x, ref object y, ref object z, int use_exact_coords)
        {
            object local_x = x;
            object local_y = y;
            object local_z = z;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetPanelPath(pnts, ref local_x, ref local_y, ref local_z, use_exact_coords));
            x = local_x;
            y = local_y;
            z = local_z;
            return retVal;
        }

        public int SetPhysicalConnectionDirection(int conndir)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPhysicalConnectionDirection(conndir));
        }

        public int SetPhysicalConnectionType(int conntyp)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPhysicalConnectionType(conntyp));
        }

        public int SetPhysicalMaxConnections(int conncount)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPhysicalMaxConnections(conncount));
        }

        public int SetPinGender(int gender)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPinGender(gender));
        }

        public int SetRoutingOffset(double x, double y, double z, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRoutingOffset(x, y, z, flags));
        }

        public int SetSignalName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSignalName(name));
        }

        public int SetWireType(string comp, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetWireType(comp, name));
        }

        public int UnassignFrom(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnassignFrom(id));
        }

        public int UnlockObject(string password)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnlockObject(password));
        }

        public int UnplugFromMatingPin(ref object pinids)
        {
            object local_pinids = pinids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.UnplugFromMatingPin(ref local_pinids));
            pinids = local_pinids;
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

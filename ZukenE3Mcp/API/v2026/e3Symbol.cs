using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Symbol : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Symbol _raw;
        private bool _disposed;

        public e3Symbol(Zuken.E3.Interop.e3Symbol raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Symbol RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int AddToSheetReference(int symi)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddToSheetReference(symi));
        }

        public int AssignFunctionalPorts(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AssignFunctionalPorts(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int AssignTo(int AssignTo, int nonodeassignment)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AssignTo(AssignTo, nonodeassignment));
        }

        public int AssignToConnector(ref object AssignToPinIds, ref object AssignToPinIds_connected, int flags)
        {
            object local_AssignToPinIds = AssignToPinIds;
            object local_AssignToPinIds_connected = AssignToPinIds_connected;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AssignToConnector(ref local_AssignToPinIds, ref local_AssignToPinIds_connected, flags));
            AssignToPinIds = local_AssignToPinIds;
            AssignToPinIds_connected = local_AssignToPinIds_connected;
            return retVal;
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int GetArea(ref object xmin, ref object ymin, ref object xmax, ref object ymax)
        {
            object local_xmin = xmin;
            object local_ymin = ymin;
            object local_xmax = xmax;
            object local_ymax = ymax;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetArea(ref local_xmin, ref local_ymin, ref local_xmax, ref local_ymax));
            xmin = local_xmin;
            ymin = local_ymin;
            xmax = local_xmax;
            ymax = local_ymax;
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

        public int GetBlockHatchColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockHatchColour());
        }

        public double GetBlockHatchDistance()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockHatchDistance());
        }

        public int GetBlockHatchPattern(ref object angle1, ref object angle2)
        {
            object local_angle1 = angle1;
            object local_angle2 = angle2;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBlockHatchPattern(ref local_angle1, ref local_angle2));
            angle1 = local_angle1;
            angle2 = local_angle2;
            return retVal;
        }

        public int GetBlockHatchStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockHatchStyle());
        }

        public double GetBlockHatchWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockHatchWidth());
        }

        public int GetBlockOutlineColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockOutlineColour());
        }

        public int GetBlockOutlineStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockOutlineStyle());
        }

        public double GetBlockOutlineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockOutlineWidth());
        }

        public int GetBoundIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBoundIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetCharacteristic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCharacteristic());
        }

        public int GetCode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCode());
        }

        public int GetDBTextSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDBTextSize());
        }

        public int GetDevicePinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDevicePinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public double GetDisplayLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayLength());
        }

        public double GetDisplayWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayWidth());
        }

        public int GetDynamicChildrenIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDynamicChildrenIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetDynamicParentId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDynamicParentId());
        }

        public int GetGateId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGateId());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetGroupId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGroupId());
        }

        public int GetHyperlinkTextIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetHyperlinkTextIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLevel());
        }

        public int GetMasterCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMasterCount());
        }

        public int GetMasterIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetMasterIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
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

        public int GetPlacedArea(ref object xmin, ref object ymin, ref object xmax, ref object ymax)
        {
            object local_xmin = xmin;
            object local_ymin = ymin;
            object local_xmax = xmax;
            object local_ymax = ymax;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPlacedArea(ref local_xmin, ref local_ymin, ref local_xmax, ref local_ymax));
            xmin = local_xmin;
            ymin = local_ymin;
            xmax = local_xmax;
            ymax = local_ymax;
            return retVal;
        }

        public int GetPlacedPolygon(ref object npnts, ref object xarr, ref object yarr)
        {
            object local_npnts = npnts;
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPlacedPolygon(ref local_npnts, ref local_xarr, ref local_yarr));
            npnts = local_npnts;
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public string GetReferenceText()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetReferenceText());
        }

        public int GetReferenceTextExtent(ref object xarr, ref object yarr)
        {
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetReferenceTextExtent(ref local_xarr, ref local_yarr));
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public int GetReferenceTextExtentSingleLine(ref object nlines, ref object xarr, ref object yarr)
        {
            object local_nlines = nlines;
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetReferenceTextExtentSingleLine(ref local_nlines, ref local_xarr, ref local_yarr));
            nlines = local_nlines;
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public int GetReferenceTextSingleLine(ref object textarr)
        {
            object local_textarr = textarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetReferenceTextSingleLine(ref local_textarr));
            textarr = local_textarr;
            return retVal;
        }

        public string GetRotation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRotation());
        }

        public double GetScaling()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetScaling());
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

        public int GetSchemaLocationShared(int shtId, ref object x, ref object y, ref object grid, ref object column_value, ref object row_value)
        {
            object local_x = x;
            object local_y = y;
            object local_grid = grid;
            object local_column_value = column_value;
            object local_row_value = row_value;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSchemaLocationShared(shtId, ref local_x, ref local_y, ref local_grid, ref local_column_value, ref local_row_value));
            x = local_x;
            y = local_y;
            grid = local_grid;
            column_value = local_column_value;
            row_value = local_row_value;
            return retVal;
        }

        public int GetSchematicTypes(ref object types)
        {
            object local_types = types;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSchematicTypes(ref local_types));
            types = local_types;
            return retVal;
        }

        public int GetSharedPinGroupState()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSharedPinGroupState());
        }

        public int GetSheetReferenceInfo(out object inout, out object type, out object refnam, out object signam)
        {
            object local_inout = default;
            object local_type = default;
            object local_refnam = default;
            object local_signam = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSheetReferenceInfo(out local_inout, out local_type, out local_refnam, out local_signam));
            inout = local_inout;
            type = local_type;
            refnam = local_refnam;
            signam = local_signam;
            return retVal;
        }

        public int GetSlaveCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSlaveCount());
        }

        public int GetSlaveIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSlaveIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetStateId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetStateId());
        }

        public int GetStateIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetStateIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSubType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSubType());
        }

        public int GetSymbolCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolCount());
        }

        public int GetSymbolExtend(ref object xarr, ref object yarr)
        {
            object local_xarr = xarr;
            object local_yarr = yarr;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolExtend(ref local_xarr, ref local_yarr));
            xarr = local_xarr;
            yarr = local_yarr;
            return retVal;
        }

        public int GetSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSymbolType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolType());
        }

        public int GetSymbolTypeId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolTypeId());
        }

        public string GetSymbolTypeName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolTypeName());
        }

        public int GetTableBreakTableAfter()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTableBreakTableAfter());
        }

        public int GetTableBreakTableAfterNumberOfRows()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTableBreakTableAfterNumberOfRows());
        }

        public int GetTableOneRowForEachCore()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTableOneRowForEachCore());
        }

        public int GetTablePinsWithoutCores()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTablePinsWithoutCores());
        }

        public int GetTargetObjectId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTargetObjectId());
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

        public int GetTransformationMatrix(ref object array)
        {
            object local_array = array;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTransformationMatrix(ref local_array));
            array = local_array;
            return retVal;
        }

        public string GetType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetType());
        }

        public string GetTypeName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTypeName());
        }

        public int GetValidCharacteristics(ref object characteristics)
        {
            object local_characteristics = characteristics;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetValidCharacteristics(ref local_characteristics));
            characteristics = local_characteristics;
            return retVal;
        }

        public string GetVersion()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVersion());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int HasNoGraphic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasNoGraphic());
        }

        public int HasPassWirePins()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasPassWirePins());
        }

        public int IsBlock()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBlock());
        }

        public int IsBundle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBundle());
        }

        public int IsConnected()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsConnected());
        }

        public int IsConnectorMaster()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsConnectorMaster());
        }

        public int IsDynamic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsDynamic());
        }

        public int IsDynamicFixed()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsDynamicFixed());
        }

        public int IsFormboard()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFormboard());
        }

        public int IsMaster()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsMaster());
        }

        public int IsOffline()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsOffline());
        }

        public int IsPinView()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPinView());
        }

        public int IsProtection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsProtection());
        }

        public int IsShield()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsShield());
        }

        public int IsTwisted()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsTwisted());
        }

        public int Jump()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Jump());
        }

        public int Load(string name, string version)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Load(name, version));
        }

        public int ModifyBlockSize(int border, double delta, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ModifyBlockSize(border, delta, flags));
        }

        public int Place(int shti, double x, double y, string rot, double scale, int maintaintextsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Place(shti, x, y, rot, scale, maintaintextsize));
        }

        public int PlaceAsGraphic(int shti, double x, double y, string rot, double scale, int maintaintextsize, int srcid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceAsGraphic(shti, x, y, rot, scale, maintaintextsize, srcid));
        }

        public int PlaceBlock(int shti, double x, double y, double width, double height, int parent)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceBlock(shti, x, y, width, height, parent));
        }

        public int PlaceDynamic(int shti, double x, double y, double height, double width, string texttemplate, short fitsymbol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceDynamic(shti, x, y, height, width, texttemplate, fitsymbol));
        }

        public int PlaceInteractively()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceInteractively());
        }

        public int PlacePins(ref object pinarray, string symname, string vers, int shti, double x, double y, string rot, double scale)
        {
            object local_pinarray = pinarray;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PlacePins(ref local_pinarray, symname, vers, shti, x, y, rot, scale));
            pinarray = local_pinarray;
            return retVal;
        }

        public int PlacePinView(int pinid, int shti, string symname, string version, double x, double y, string rot, double scale, int maintaintextsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlacePinView(pinid, shti, symname, version, x, y, rot, scale, maintaintextsize));
        }

        public int PlaceTable(int fromID, double x, double y, string rot, double scale, int maintaintextsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceTable(fromID, x, y, rot, scale, maintaintextsize));
        }

        public int RemoveFromSheetReference()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.RemoveFromSheetReference());
        }

        public int SendToBackground()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SendToBackground());
        }

        public int SendToForeground()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SendToForeground());
        }

        public int SetAsMaster(int on)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAsMaster(on));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetBlockHatchColour(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockHatchColour(value));
        }

        public double SetBlockHatchDistance(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockHatchDistance(value));
        }

        public int SetBlockHatchPattern(int value, double angle1, double angle2)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockHatchPattern(value, angle1, angle2));
        }

        public int SetBlockHatchStyle(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockHatchStyle(value));
        }

        public double SetBlockHatchWidth(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockHatchWidth(value));
        }

        public int SetBlockOutlineColour(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockOutlineColour(value));
        }

        public int SetBlockOutlineStyle(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockOutlineStyle(value));
        }

        public double SetBlockOutlineWidth(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockOutlineWidth(value));
        }

        public int SetCharacteristic(string characteristic)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCharacteristic(characteristic));
        }

        public int SetDBTextSize(int txtsiz)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDBTextSize(txtsiz));
        }

        public int SetDeviceAssignment(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceAssignment(name));
        }

        public int SetDeviceCompleteName(string name, string ass, string loc, int onlygiven)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceCompleteName(name, ass, loc, onlygiven));
        }

        public int SetDeviceLocation(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceLocation(name));
        }

        public int SetDeviceName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceName(name));
        }

        public int SetDisplayLength(double length)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayLength(length));
        }

        public int SetDisplayWidth(double width)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayWidth(width));
        }

        public int SetGateId(int symid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGateId(symid));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetLevel(int level)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLevel(level));
        }

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
        }

        public int SetOptionExpressions(ref object expressions)
        {
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetOptionExpressions(ref local_expressions));
            expressions = local_expressions;
            return retVal;
        }

        public double SetScaling(double scale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetScaling(scale));
        }

        public int SetSelected(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSelected(newval));
        }

        public int SetSharedPinGroupState(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSharedPinGroupState(newval));
        }

        public int SetStateId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetStateId(id));
        }

        public int SetTableBreakTableAfter(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTableBreakTableAfter(newval));
        }

        public int SetTableBreakTableAfterNumberOfRows(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTableBreakTableAfterNumberOfRows(newval));
        }

        public int SetTableOneRowForEachCore(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTableOneRowForEachCore(newval));
        }

        public int SetTablePinsWithoutCores(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTablePinsWithoutCores(newval));
        }

        public int SetType(string name, string version)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetType(name, version));
        }

        public int UnGroup()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnGroup());
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

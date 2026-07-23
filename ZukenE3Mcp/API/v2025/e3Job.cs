using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3Job : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Job _raw;
        private bool _disposed;

        public e3Job(Zuken.E3.Interop.e3Job raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Job RawObject => _raw;

        public int ActivateOptionAlias(string alias)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ActivateOptionAlias(alias));
        }

        public int ActivateOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ActivateOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int AddOptionAlias(string name, string description)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddOptionAlias(name, description));
        }

        public int ClearItemCollectors()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ClearItemCollectors());
        }

        public int Close()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Close());
        }

        public int ConvertMultiByteToWideChar(int code_page)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ConvertMultiByteToWideChar(code_page));
        }

        public int Create(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name));
        }

        public e3AttributeDefinition CreateAttributeDefinitionObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateAttributeDefinitionObject());
            return rawResult != null ? new e3AttributeDefinition((Zuken.E3.Interop.e3AttributeDefinition)rawResult) : null;
        }

        public e3Attribute CreateAttributeObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateAttributeObject());
            return rawResult != null ? new e3Attribute((Zuken.E3.Interop.e3Attribute)rawResult) : null;
        }

        public e3BinData CreateBinDataObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateBinDataObject());
            return rawResult != null ? new e3BinData((Zuken.E3.Interop.e3BinData)rawResult) : null;
        }

        public e3Board CreateBoardObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateBoardObject());
            return rawResult != null ? new e3Board((Zuken.E3.Interop.e3Board)rawResult) : null;
        }

        public e3Bundle CreateBundleObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateBundleObject());
            return rawResult != null ? new e3Bundle((Zuken.E3.Interop.e3Bundle)rawResult) : null;
        }

        public e3CavityPart CreateCavityPartObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateCavityPartObject());
            return rawResult != null ? new e3CavityPart((Zuken.E3.Interop.e3CavityPart)rawResult) : null;
        }

        public e3Clipboard CreateClipboardObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateClipboardObject());
            return rawResult != null ? new e3Clipboard((Zuken.E3.Interop.e3Clipboard)rawResult) : null;
        }

        public e3Component CreateComponentObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateComponentObject());
            return rawResult != null ? new e3Component((Zuken.E3.Interop.e3Component)rawResult) : null;
        }

        public e3Connection CreateConnectionObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateConnectionObject());
            return rawResult != null ? new e3Connection((Zuken.E3.Interop.e3Connection)rawResult) : null;
        }

        public e3ConnectLine CreateConnectLineObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateConnectLineObject());
            return rawResult != null ? new e3ConnectLine((Zuken.E3.Interop.e3ConnectLine)rawResult) : null;
        }

        public object CreateDebugObject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateDebugObject());
        }

        public e3Device CreateDeviceObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDeviceObject());
            return rawResult != null ? new e3Device((Zuken.E3.Interop.e3Device)rawResult) : null;
        }

        public e3Dimension CreateDimensionObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDimensionObject());
            return rawResult != null ? new e3Dimension((Zuken.E3.Interop.e3Dimension)rawResult) : null;
        }

        public object CreateEmbeddedObject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateEmbeddedObject());
        }

        public e3ExternalDocument CreateExternalDocumentObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateExternalDocumentObject());
            return rawResult != null ? new e3ExternalDocument((Zuken.E3.Interop.e3ExternalDocument)rawResult) : null;
        }

        public e3Field CreateFieldObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateFieldObject());
            return rawResult != null ? new e3Field((Zuken.E3.Interop.e3Field)rawResult) : null;
        }

        public e3FunctionalPort CreateFunctionalPortObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateFunctionalPortObject());
            return rawResult != null ? new e3FunctionalPort((Zuken.E3.Interop.e3FunctionalPort)rawResult) : null;
        }

        public e3FunctionalUnit CreateFunctionalUnitObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateFunctionalUnitObject());
            return rawResult != null ? new e3FunctionalUnit((Zuken.E3.Interop.e3FunctionalUnit)rawResult) : null;
        }

        public e3Graph CreateGraphObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateGraphObject());
            return rawResult != null ? new e3Graph((Zuken.E3.Interop.e3Graph)rawResult) : null;
        }

        public e3Group CreateGroupObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateGroupObject());
            return rawResult != null ? new e3Group((Zuken.E3.Interop.e3Group)rawResult) : null;
        }

        public int CreateInlineConnectors(out object newCoreIDs, out object newDeviceIDs, int flags, ref object fromPinIDs, ref object toPinIDs, ref object viewNumbers, ref object fBSheetIDs, string CompName, string CompVersion)
        {
            object local_newCoreIDs = default;
            object local_newDeviceIDs = default;
            object local_fromPinIDs = fromPinIDs;
            object local_toPinIDs = toPinIDs;
            object local_viewNumbers = viewNumbers;
            object local_fBSheetIDs = fBSheetIDs;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateInlineConnectors(out local_newCoreIDs, out local_newDeviceIDs, flags, ref local_fromPinIDs, ref local_toPinIDs, ref local_viewNumbers, ref local_fBSheetIDs, CompName, CompVersion));
            newCoreIDs = local_newCoreIDs;
            newDeviceIDs = local_newDeviceIDs;
            fromPinIDs = local_fromPinIDs;
            toPinIDs = local_toPinIDs;
            viewNumbers = local_viewNumbers;
            fBSheetIDs = local_fBSheetIDs;
            return retVal;
        }

        public int CreateInlineConnectorsEx(out object newCoreIDs, out object newDeviceIDs, int flags, ref object fromPinIDs, ref object toPinIDs, ref object viewNumbers, ref object fBSheetIDs, string CompName, string CompVersion, ref object newSymbolIDs)
        {
            object local_newCoreIDs = default;
            object local_newDeviceIDs = default;
            object local_fromPinIDs = fromPinIDs;
            object local_toPinIDs = toPinIDs;
            object local_viewNumbers = viewNumbers;
            object local_fBSheetIDs = fBSheetIDs;
            object local_newSymbolIDs = newSymbolIDs;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateInlineConnectorsEx(out local_newCoreIDs, out local_newDeviceIDs, flags, ref local_fromPinIDs, ref local_toPinIDs, ref local_viewNumbers, ref local_fBSheetIDs, CompName, CompVersion, ref local_newSymbolIDs));
            newCoreIDs = local_newCoreIDs;
            newDeviceIDs = local_newDeviceIDs;
            fromPinIDs = local_fromPinIDs;
            toPinIDs = local_toPinIDs;
            viewNumbers = local_viewNumbers;
            fBSheetIDs = local_fBSheetIDs;
            newSymbolIDs = local_newSymbolIDs;
            return retVal;
        }

        public int CreateInlineConnectorsOnConnectionLine(out object newCoreIDs, out object newDeviceIDs, int flags, ref object LineIDs, string CompName, string CompVersion, ref object newSymbolIDs)
        {
            object local_newCoreIDs = default;
            object local_newDeviceIDs = default;
            object local_LineIDs = LineIDs;
            object local_newSymbolIDs = newSymbolIDs;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CreateInlineConnectorsOnConnectionLine(out local_newCoreIDs, out local_newDeviceIDs, flags, ref local_LineIDs, CompName, CompVersion, ref local_newSymbolIDs));
            newCoreIDs = local_newCoreIDs;
            newDeviceIDs = local_newDeviceIDs;
            LineIDs = local_LineIDs;
            newSymbolIDs = local_newSymbolIDs;
            return retVal;
        }

        public e3Layer CreateLayerObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateLayerObject());
            return rawResult != null ? new e3Layer((Zuken.E3.Interop.e3Layer)rawResult) : null;
        }

        public e3Module CreateModuleObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateModuleObject());
            return rawResult != null ? new e3Module((Zuken.E3.Interop.e3Module)rawResult) : null;
        }

        public e3ModulePort CreateModulePortObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateModulePortObject());
            return rawResult != null ? new e3ModulePort((Zuken.E3.Interop.e3ModulePort)rawResult) : null;
        }

        public e3Net CreateNetObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateNetObject());
            return rawResult != null ? new e3Net((Zuken.E3.Interop.e3Net)rawResult) : null;
        }

        public e3NetSegment CreateNetSegmentObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateNetSegmentObject());
            return rawResult != null ? new e3NetSegment((Zuken.E3.Interop.e3NetSegment)rawResult) : null;
        }

        public e3Option CreateOptionObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateOptionObject());
            return rawResult != null ? new e3Option((Zuken.E3.Interop.e3Option)rawResult) : null;
        }

        public e3Outline CreateOutlineObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateOutlineObject());
            return rawResult != null ? new e3Outline((Zuken.E3.Interop.e3Outline)rawResult) : null;
        }

        public e3Pin CreatePinObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreatePinObject());
            return rawResult != null ? new e3Pin((Zuken.E3.Interop.e3Pin)rawResult) : null;
        }

        public e3Sheet CreateSheetObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateSheetObject());
            return rawResult != null ? new e3Sheet((Zuken.E3.Interop.e3Sheet)rawResult) : null;
        }

        public object CreateSignalClassObject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateSignalClassObject());
        }

        public e3Signal CreateSignalObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateSignalObject());
            return rawResult != null ? new e3Signal((Zuken.E3.Interop.e3Signal)rawResult) : null;
        }

        public e3Slot CreateSlotObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateSlotObject());
            return rawResult != null ? new e3Slot((Zuken.E3.Interop.e3Slot)rawResult) : null;
        }

        public e3State CreateStateObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateStateObject());
            return rawResult != null ? new e3State((Zuken.E3.Interop.e3State)rawResult) : null;
        }

        public e3StructureNode CreateStructureNodeObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateStructureNodeObject());
            return rawResult != null ? new e3StructureNode((Zuken.E3.Interop.e3StructureNode)rawResult) : null;
        }

        public e3Supply CreateSupplyObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateSupplyObject());
            return rawResult != null ? new e3Supply((Zuken.E3.Interop.e3Supply)rawResult) : null;
        }

        public e3Symbol CreateSymbolObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateSymbolObject());
            return rawResult != null ? new e3Symbol((Zuken.E3.Interop.e3Symbol)rawResult) : null;
        }

        public e3Testpoint CreateTestpointObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateTestpointObject());
            return rawResult != null ? new e3Testpoint((Zuken.E3.Interop.e3Testpoint)rawResult) : null;
        }

        public e3Text CreateTextObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateTextObject());
            return rawResult != null ? new e3Text((Zuken.E3.Interop.e3Text)rawResult) : null;
        }

        public e3Tree CreateTreeObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateTreeObject());
            return rawResult != null ? new e3Tree((Zuken.E3.Interop.e3Tree)rawResult) : null;
        }

        public e3Variant CreateVariantObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateVariantObject());
            return rawResult != null ? new e3Variant((Zuken.E3.Interop.e3Variant)rawResult) : null;
        }

        public int DeactivateOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.DeactivateOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DeleteAttributeDefinition(string attnam)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttributeDefinition(attnam));
        }

        public int DeleteMultiuser(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteMultiuser(name));
        }

        public int DeleteOptionAlias(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteOptionAlias(name));
        }

        public int DisablePointGridDisplay()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisablePointGridDisplay());
        }

        public int DisableRulerGridDisplay()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisableRulerGridDisplay());
        }

        public void DisableSuffixSuppression()
        {
            StaThreadExecutor.Instance.Execute(() => _raw.DisableSuffixSuppression());
        }

        public int DumpItem(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DumpItem(id));
        }

        public int EnablePointGridDisplay()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.EnablePointGridDisplay());
        }

        public int EnableRulerGridDisplay()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.EnableRulerGridDisplay());
        }

        public void EnableSuffixSuppression()
        {
            StaThreadExecutor.Instance.Execute(() => _raw.EnableSuffixSuppression());
        }

        public int ExportAllComponentsToDB(int bOverwrite)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportAllComponentsToDB(bOverwrite));
        }

        public int ExportAllModelsToDB(int bOverwrite)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportAllModelsToDB(bOverwrite));
        }

        public int ExportAllSymbolsToDB(int bOverwrite)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportAllSymbolsToDB(bOverwrite));
        }

        public int ExportBoardLayout(string type, string file, int flags, string map, ref object exclusions)
        {
            object local_exclusions = exclusions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportBoardLayout(type, file, flags, map, ref local_exclusions));
            exclusions = local_exclusions;
            return retVal;
        }

        public int ExportCGM(string file, ref object shtids, int options)
        {
            object local_shtids = shtids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportCGM(file, ref local_shtids, options));
            shtids = local_shtids;
            return retVal;
        }

        public int ExportComponentToDB(string CompName, string CompVersion, int bOverwrite)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportComponentToDB(CompName, CompVersion, bOverwrite));
        }

        public int ExportDrawing(string name, ref object shtids, int options)
        {
            object local_shtids = shtids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportDrawing(name, ref local_shtids, options));
            shtids = local_shtids;
            return retVal;
        }

        public int ExportForeign(string format, string file)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportForeign(format, file));
        }

        public int ExportImageItems(string format, int version, string file, ref object items, int percentage, int width, int height, int clrdepth, int gray, int dpiX, int dpiY, int compressionmode)
        {
            object local_items = items;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportImageItems(format, version, file, ref local_items, percentage, width, height, clrdepth, gray, dpiX, dpiY, compressionmode));
            items = local_items;
            return retVal;
        }

        public int ExportJT(string file, ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportJT(file, ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int ExportModelToDB(string CompName, string CompVersion, int bOverwrite)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportModelToDB(CompName, CompVersion, bOverwrite));
        }

        public int ExportMultiuser(string file, uint fileformat, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportMultiuser(file, fileformat, name));
        }

        public int ExportPDF(string file, ref object shtids, int options, string password)
        {
            object local_shtids = shtids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportPDF(file, ref local_shtids, options, password));
            shtids = local_shtids;
            return retVal;
        }

        public int ExportPDFEx(string file, ref object shtids, int options, int itemListType, ref object items, int alternativeColour, int imageBrightness, string password)
        {
            object local_shtids = shtids;
            object local_items = items;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportPDFEx(file, ref local_shtids, options, itemListType, ref local_items, alternativeColour, imageBrightness, password));
            shtids = local_shtids;
            items = local_items;
            return retVal;
        }

        public int ExportSVGByArea(string file, int shtId, double xmin, double ymin, double xmax, double ymax, double originX, double originY, int selectionMode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportSVGByArea(file, shtId, xmin, ymin, xmax, ymax, originX, originY, selectionMode));
        }

        public int ExportSVGBySheet(string file, ref object shtids)
        {
            object local_shtids = shtids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportSVGBySheet(file, ref local_shtids));
            shtids = local_shtids;
            return retVal;
        }

        public int ExportSVGBySheetEx(string file, ref object shtids, int options)
        {
            object local_shtids = shtids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportSVGBySheetEx(file, ref local_shtids, options));
            shtids = local_shtids;
            return retVal;
        }

        public int ExportSymbolToDB(string SymbolName, string SymbolVersion, int bOverwrite)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportSymbolToDB(SymbolName, SymbolVersion, bOverwrite));
        }

        public int ExportTemplate(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportTemplate(filename));
        }

        public int ExportToDB(int bOverwrite)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportToDB(bOverwrite));
        }

        public int ExportXVL(string file, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ExportXVL(file, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int FinalizeTransaction()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FinalizeTransaction());
        }

        public int FindPanelPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FindPanelPath());
        }

        public int FreeWireNumber(int number)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FreeWireNumber(number));
        }

        public int GetActiveAlias(out object name)
        {
            object local_name = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetActiveAlias(out local_name));
            name = local_name;
            return retVal;
        }

        public int GetActiveOptionCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetActiveOptionCount());
        }

        public int GetActiveOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetActiveOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetActiveSheetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetActiveSheetId());
        }

        public int GetActiveSheetTreeID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetActiveSheetTreeID());
        }

        public int GetActiveTreeID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetActiveTreeID());
        }

        public int GetActiveVariantId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetActiveVariantId());
        }

        public int GetAddDeviceDesignationOfConnectionTarget()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAddDeviceDesignationOfConnectionTarget());
        }

        public int GetAllBusbarConnectionIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllBusbarConnectionIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetAllComponentCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAllComponentCount());
        }

        public int GetAllComponentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllComponentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetAllConnectionCount(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAllConnectionCount(flags));
        }

        public int GetAllConnectionIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllConnectionIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetAllDeviceCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAllDeviceCount());
        }

        public int GetAllDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetAllOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetAllParentSheetIds(int flags, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllParentSheetIds(flags, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetAllSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAllSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public double GetAltGridSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAltGridSize());
        }

        public int GetAnyAttributeIds(string attnam, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAnyAttributeIds(attnam, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetAssignmentSeparator()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAssignmentSeparator());
        }

        public string GetAssignmentSuffixSeparator()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAssignmentSuffixSeparator());
        }

        public int GetAttributeCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeCount());
        }

        public int GetAttributeDefinitionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeDefinitionIds(ref local_ids));
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

        public int GetAttributeNotInheritable(string attnam)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeNotInheritable(attnam));
        }

        public string GetAttributeValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeValue(name));
        }

        public int GetAvailableLanguages(ref object languages)
        {
            object local_languages = languages;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAvailableLanguages(ref local_languages));
            languages = local_languages;
            return retVal;
        }

        public int GetBlockCopyGraphicInSplit()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockCopyGraphicInSplit());
        }

        public int GetBlockCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockCount());
        }

        public int GetBlockIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBlockIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetBlockReferenceTextDirection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockReferenceTextDirection());
        }

        public double GetBlockReferenceTextGap()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockReferenceTextGap());
        }

        public int GetBlockReferenceTextLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockReferenceTextLevel());
        }

        public int GetBlockReferenceTextRotate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockReferenceTextRotate());
        }

        public int GetBlockReferenceType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockReferenceType());
        }

        public int GetBlockTextAlignment()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockTextAlignment());
        }

        public int GetBlockTextColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockTextColour());
        }

        public string GetBlockTextFont()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockTextFont());
        }

        public int GetBlockTextRatio()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockTextRatio());
        }

        public double GetBlockTextSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockTextSize());
        }

        public int GetBlockTextStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBlockTextStyle());
        }

        public int GetBoardIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBoardIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetBomPartList(string consumer, string outputFormatVersion, int flags, string keyAttribut, string quantityAttribut, string lengthAttribut, ref object additionalAttributes, ref object result)
        {
            object local_additionalAttributes = additionalAttributes;
            object local_result = result;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBomPartList(consumer, outputFormatVersion, flags, keyAttribut, quantityAttribut, lengthAttribut, ref local_additionalAttributes, ref local_result));
            additionalAttributes = local_additionalAttributes;
            result = local_result;
            return retVal;
        }

        public int GetBooleanState(string expression)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBooleanState(expression));
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

        public int GetBusbarIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetBusbarIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetBusLineColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBusLineColour());
        }

        public int GetBusLineLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBusLineLevel());
        }

        public int GetBusLineStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBusLineStyle());
        }

        public int GetBusLineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBusLineWidth());
        }

        public double GetBusLineWidthEx()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBusLineWidthEx());
        }

        public int GetCableCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCableCount());
        }

        public int GetCableIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCableIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCableTypeCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCableTypeCount());
        }

        public int GetCableTypeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCableTypeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetCadstarCrossProbing()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCadstarCrossProbing());
        }

        public int GetCavityPartIds(ref object ids, int type)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCavityPartIds(ref local_ids, type));
            ids = local_ids;
            return retVal;
        }

        public int GetClipboardIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetClipboardIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetComponentCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentCount());
        }

        public int GetComponentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetComponentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetConnectionCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectionCount());
        }

        public int GetConnectionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public double GetConnectionInclinationAngle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectionInclinationAngle());
        }

        public double GetConnectionInclinationDistance()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectionInclinationDistance());
        }

        public int GetConnectionMode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectionMode());
        }

        public int GetConnectionTargetFormat(int txttyp, out object flags, out object entire_prefix, out object entire_suffix, out object count, out object prefix, out object name, out object funct)
        {
            object local_flags = default;
            object local_entire_prefix = default;
            object local_entire_suffix = default;
            object local_count = default;
            object local_prefix = default;
            object local_name = default;
            object local_funct = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectionTargetFormat(txttyp, out local_flags, out local_entire_prefix, out local_entire_suffix, out local_count, out local_prefix, out local_name, out local_funct));
            flags = local_flags;
            entire_prefix = local_entire_prefix;
            entire_suffix = local_entire_suffix;
            count = local_count;
            prefix = local_prefix;
            name = local_name;
            funct = local_funct;
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

        public int GetConnectorPinTerminalParameterOverwriteModelPin()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConnectorPinTerminalParameterOverwriteModelPin());
        }

        public int GetConnectorSymbolFormat(out object texttypes, out object dispflags)
        {
            object local_texttypes = default;
            object local_dispflags = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetConnectorSymbolFormat(out local_texttypes, out local_dispflags));
            texttypes = local_texttypes;
            dispflags = local_dispflags;
            return retVal;
        }

        public int GetCreateUniqueSheetNames()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCreateUniqueSheetNames());
        }

        public string GetCurrentUserName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCurrentUserName());
        }

        public int GetCurrentUserNames(ref object names)
        {
            object local_names = names;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCurrentUserNames(ref local_names));
            names = local_names;
            return retVal;
        }

        public int GetCursorPosition(ref object xpos, ref object ypos)
        {
            object local_xpos = xpos;
            object local_ypos = ypos;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCursorPosition(ref local_xpos, ref local_ypos));
            xpos = local_xpos;
            ypos = local_ypos;
            return retVal;
        }

        public int GetCursorPositionInteractively(out object xpos, out object ypos, int flags, out object keysAndMouseButtons, out object grid, out object gridX, out object gridY, double boxWidth, double boxHeight)
        {
            object local_xpos = default;
            object local_ypos = default;
            object local_keysAndMouseButtons = default;
            object local_grid = default;
            object local_gridX = default;
            object local_gridY = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetCursorPositionInteractively(out local_xpos, out local_ypos, flags, out local_keysAndMouseButtons, out local_grid, out local_gridX, out local_gridY, boxWidth, boxHeight));
            xpos = local_xpos;
            ypos = local_ypos;
            keysAndMouseButtons = local_keysAndMouseButtons;
            grid = local_grid;
            gridX = local_gridX;
            gridY = local_gridY;
            return retVal;
        }

        public int GetDefaultHoseTube(out object HoseTube)
        {
            object local_HoseTube = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDefaultHoseTube(out local_HoseTube));
            HoseTube = local_HoseTube;
            return retVal;
        }

        public int GetDefaultJumper(out object jumpergroup, out object jumpername)
        {
            object local_jumpergroup = default;
            object local_jumpername = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDefaultJumper(out local_jumpergroup, out local_jumpername));
            jumpergroup = local_jumpergroup;
            jumpername = local_jumpername;
            return retVal;
        }

        public int GetDefaultWire(out object wiregroup, out object wirename)
        {
            object local_wiregroup = default;
            object local_wirename = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDefaultWire(out local_wiregroup, out local_wirename));
            wiregroup = local_wiregroup;
            wirename = local_wirename;
            return retVal;
        }

        public int GetDeleteCoresOnDelCline()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDeleteCoresOnDelCline());
        }

        public int GetDeletePinAttributesOnUnplace()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDeletePinAttributesOnUnplace());
        }

        public int GetDeleteSignalOnDelCline()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDeleteSignalOnDelCline());
        }

        public int GetDetermineConnectorSymbol()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDetermineConnectorSymbol());
        }

        public int GetDetermineConnectorViewSymbol()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDetermineConnectorViewSymbol());
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

        public string GetDeviceNameSeparator()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDeviceNameSeparator());
        }

        public string GetDeviceNameSuffixSeparator()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDeviceNameSuffixSeparator());
        }

        public string GetDisplayAltCompCode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayAltCompCode());
        }

        public int GetDisplayAppendFormboardNameToDeviceName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayAppendFormboardNameToDeviceName());
        }

        public int GetDisplayConnectionMode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayConnectionMode());
        }

        public int GetDisplayConnectionType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayConnectionType());
        }

        public int GetDisplayConnectPoints()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayConnectPoints());
        }

        public int GetDisplayDuctDockingPoints()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayDuctDockingPoints());
        }

        public int GetDisplayDuctFillSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayDuctFillSize());
        }

        public int GetDisplayFormboardEffectiveDirection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayFormboardEffectiveDirection());
        }

        public int GetDisplayFormboardMarkDifferenLength()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayFormboardMarkDifferenLength());
        }

        public int GetDisplayFormboardNodes()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayFormboardNodes());
        }

        public int GetDisplayFormboardTableSubsidiaryLines()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayFormboardTableSubsidiaryLines());
        }

        public int GetDisplayFormboardUnconnectedCores()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayFormboardUnconnectedCores());
        }

        public int GetDisplayIntExtRepresentation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayIntExtRepresentation());
        }

        public int GetDisplayMILStandard()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayMILStandard());
        }

        public int GetDisplayOptionsAll()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayOptionsAll());
        }

        public int GetDisplayOptionsColoured()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayOptionsColoured());
        }

        public int GetDisplayOptionsNone()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayOptionsNone());
        }

        public int GetDisplayRotatedTextAccStandard()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayRotatedTextAccStandard());
        }

        public int GetDisplayUnconnectedNodes()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayUnconnectedNodes());
        }

        public int GetDisplayViewNumbers()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayViewNumbers());
        }

        public int GetExclusiveMode(string name, out object user)
        {
            object local_user = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetExclusiveMode(name, out local_user));
            user = local_user;
            return retVal;
        }

        public int GetExportWithCablesAndWires()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetExportWithCablesAndWires());
        }

        public int GetExportWithCablesAndWiresOption()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetExportWithCablesAndWiresOption());
        }

        public int GetExternalDocumentCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetExternalDocumentCount());
        }

        public int GetExternalDocumentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetExternalDocumentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetFieldCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFieldCount());
        }

        public int GetFieldHatchColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFieldHatchColour());
        }

        public double GetFieldHatchLineDistance()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFieldHatchLineDistance());
        }

        public double GetFieldHatchLineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFieldHatchLineWidth());
        }

        public int GetFieldHatchPattern()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFieldHatchPattern());
        }

        public int GetFieldIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetFieldIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetFieldOutlineColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFieldOutlineColour());
        }

        public int GetFieldOutlineStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFieldOutlineStyle());
        }

        public double GetFieldOutlineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFieldOutlineWidth());
        }

        public string GetFieldTextTemplate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFieldTextTemplate());
        }

        public int GetFileVersion(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFileVersion(filename));
        }

        public int GetFormboardAutoplaceTableSymbol()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFormboardAutoplaceTableSymbol());
        }

        public int GetFormboardAutorotateConnectorSymbols()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFormboardAutorotateConnectorSymbols());
        }

        public int GetFormboardBranchAngleStep()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFormboardBranchAngleStep());
        }

        public int GetFunctionalUnitIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetFunctionalUnitIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public double GetGapToPlaceSinglePins()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGapToPlaceSinglePins());
        }

        public int GetGeneratedWireNameFormat(out object prefix, out object separator, out object postfix, out object attPrefix, out object attType, out object attname)
        {
            object local_prefix = default;
            object local_separator = default;
            object local_postfix = default;
            object local_attPrefix = default;
            object local_attType = default;
            object local_attname = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGeneratedWireNameFormat(out local_prefix, out local_separator, out local_postfix, out local_attPrefix, out local_attType, out local_attname));
            prefix = local_prefix;
            separator = local_separator;
            postfix = local_postfix;
            attPrefix = local_attPrefix;
            attType = local_attType;
            attname = local_attname;
            return retVal;
        }

        public int GetGeneratedWireNameFormatEx(out object attPrefix, out object attType, out object attname)
        {
            object local_attPrefix = default;
            object local_attType = default;
            object local_attname = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGeneratedWireNameFormatEx(out local_attPrefix, out local_attType, out local_attname));
            attPrefix = local_attPrefix;
            attType = local_attType;
            attname = local_attname;
            return retVal;
        }

        public int GetGetterOptionHandlingMode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGetterOptionHandlingMode());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public string GetGidOfId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGidOfId(id));
        }

        public int GetGraphArrows()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphArrows());
        }

        public int GetGraphColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphColour());
        }

        public int GetGraphHatchColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphHatchColour());
        }

        public double GetGraphHatchDistance()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphHatchDistance());
        }

        public int GetGraphHatchPattern(ref object angle1, ref object angle2)
        {
            object local_angle1 = angle1;
            object local_angle2 = angle2;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGraphHatchPattern(ref local_angle1, ref local_angle2));
            angle1 = local_angle1;
            angle2 = local_angle2;
            return retVal;
        }

        public int GetGraphHatchStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphHatchStyle());
        }

        public double GetGraphHatchWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphHatchWidth());
        }

        public int GetGraphLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphLevel());
        }

        public int GetGraphStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphStyle());
        }

        public int GetGraphTextColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphTextColour());
        }

        public int GetGraphTextCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphTextCount());
        }

        public string GetGraphTextFontName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphTextFontName());
        }

        public double GetGraphTextHeight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphTextHeight());
        }

        public int GetGraphTextIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGraphTextIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetGraphTextLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphTextLevel());
        }

        public int GetGraphTextMode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphTextMode());
        }

        public double GetGraphTextSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphTextSize());
        }

        public int GetGraphTextStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphTextStyle());
        }

        public double GetGraphWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphWidth());
        }

        public double GetGridSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGridSize());
        }

        public int GetGroupIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGroupIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetGUIDOfId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGUIDOfId(id));
        }

        public int GetHarnessIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetHarnessIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetHighlightColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHighlightColour());
        }

        public int GetHighlightKeep()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHighlightKeep());
        }

        public double GetHighlightLineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetHighlightLineWidth());
        }

        public int GetHoseIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetHoseIds(ref local_ids));
            ids = local_ids;
            return retVal;
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

        public int GetIdOfGid(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetIdOfGid(gid));
        }

        public int GetIdOfGUID(string guid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetIdOfGUID(guid));
        }

        public int GetIEC61346Setting()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetIEC61346Setting());
        }

        public string GetImportItemDesignationSuffix()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetImportItemDesignationSuffix());
        }

        public int GetImportMergeAttributes()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetImportMergeAttributes());
        }

        public int GetImportMergeConnectLines()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetImportMergeConnectLines());
        }

        public int GetImportMergeExistingAssemblies()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetImportMergeExistingAssemblies());
        }

        public int GetImportMergeExistingDevices()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetImportMergeExistingDevices());
        }

        public int GetImportMergeExistingTerminalStrips()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetImportMergeExistingTerminalStrips());
        }

        public int GetImportMergeOptions()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetImportMergeOptions());
        }

        public int GetImportUseItemDesignationSuffix()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetImportUseItemDesignationSuffix());
        }

        public int GetInvertDisplayColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInvertDisplayColour());
        }

        public int GetItemSheetIds(int item, out object ids)
        {
            object local_ids = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetItemSheetIds(item, out local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetItemType(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetItemType(id));
        }

        public int GetKeepActiveConnectorPinTerminalOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetKeepActiveConnectorPinTerminalOnUpdate());
        }

        public int GetKeepActiveCounterpartOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetKeepActiveCounterpartOnUpdate());
        }

        public int GetKeepActiveFittingOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetKeepActiveFittingOnUpdate());
        }

        public int GetKeepConnectorSymbolsOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetKeepConnectorSymbolsOnUpdate());
        }

        public int GetKeepModelTextParametersOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetKeepModelTextParametersOnUpdate());
        }

        public int GetKeepModelTextVisibilityOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetKeepModelTextVisibilityOnUpdate());
        }

        public int GetKeepSymbolTextParametersOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetKeepSymbolTextParametersOnUpdate());
        }

        public int GetKeepSymbolTextVisibilityOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetKeepSymbolTextVisibilityOnUpdate());
        }

        public int GetLanguages(ref object languages)
        {
            object local_languages = languages;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLanguages(ref local_languages));
            languages = local_languages;
            return retVal;
        }

        public int GetLastAddedItems(ref object ids, int type)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLastAddedItems(ref local_ids, type));
            ids = local_ids;
            return retVal;
        }

        public int GetLastDeletedAttributeValues(ref object owner_ids, ref object attribute_names, ref object attribute_values)
        {
            object local_owner_ids = owner_ids;
            object local_attribute_names = attribute_names;
            object local_attribute_values = attribute_values;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLastDeletedAttributeValues(ref local_owner_ids, ref local_attribute_names, ref local_attribute_values));
            owner_ids = local_owner_ids;
            attribute_names = local_attribute_names;
            attribute_values = local_attribute_values;
            return retVal;
        }

        public int GetLastDeletedItems(ref object items, int type)
        {
            object local_items = items;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLastDeletedItems(ref local_items, type));
            items = local_items;
            return retVal;
        }

        public int GetLastModifiedItems(ref object ids, int type)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLastModifiedItems(ref local_ids, type));
            ids = local_ids;
            return retVal;
        }

        public int GetLayerIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLayerIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetLevelIndex(string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLevelIndex(value));
        }

        public string GetLevelName(int level)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLevelName(level));
        }

        public int GetLevels(ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr, ref object txtarr, ref object cxarr, ref object names)
        {
            object local_symarr = symarr;
            object local_sgraarr = sgraarr;
            object local_stxtarr = stxtarr;
            object local_semtarr = semtarr;
            object local_graarr = graarr;
            object local_txtarr = txtarr;
            object local_cxarr = cxarr;
            object local_names = names;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLevels(ref local_symarr, ref local_sgraarr, ref local_stxtarr, ref local_semtarr, ref local_graarr, ref local_txtarr, ref local_cxarr, ref local_names));
            symarr = local_symarr;
            sgraarr = local_sgraarr;
            stxtarr = local_stxtarr;
            semtarr = local_semtarr;
            graarr = local_graarr;
            txtarr = local_txtarr;
            cxarr = local_cxarr;
            names = local_names;
            return retVal;
        }

        public int GetLineColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineColour());
        }

        public int GetLineLevel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineLevel());
        }

        public int GetLineStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineStyle());
        }

        public int GetLineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineWidth());
        }

        public double GetLineWidthEx()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLineWidthEx());
        }

        public string GetLocationSeparator()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocationSeparator());
        }

        public string GetLocationSuffixSeparator()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocationSuffixSeparator());
        }

        public string GetMeasure()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMeasure());
        }

        public int GetMergeAlphanumericReferences()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMergeAlphanumericReferences());
        }

        public int GetMergeSheetReferences()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMergeSheetReferences());
        }

        public int GetMergeUsingExactCoreConnectionOnImport()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMergeUsingExactCoreConnectionOnImport());
        }

        public int GetMILGraphicLineColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMILGraphicLineColour());
        }

        public int GetMILGraphicLineStyle()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMILGraphicLineStyle());
        }

        public double GetMILGraphicLineWidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMILGraphicLineWidth());
        }

        public int GetModuleIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetModuleIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetMultiuserPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMultiuserPath());
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

        public int GetNetSegmentAttributeSplittingRule()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNetSegmentAttributeSplittingRule());
        }

        public int GetNetSegmentLengthSplittingRule()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNetSegmentLengthSplittingRule());
        }

        public int GetNewAllDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewAllDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewBlockIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewBlockIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewBundleIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewBundleIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewCableIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewCableIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewConnectionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewConnectionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewConnectorIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewConnectorIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewCoreIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewCoreIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewFieldIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewFieldIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewGraphIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewGraphIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewSignalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewSignalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewTerminalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewTerminalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetNewTextIds(ref object ids, int txttyp, string search_string)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNewTextIds(ref local_ids, txttyp, search_string));
            ids = local_ids;
            return retVal;
        }

        public int GetNextWireNumber()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNextWireNumber());
        }

        public string GetNextWireNumberFormatted()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetNextWireNumberFormatted());
        }

        public int GetOptionAliases(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOptionAliases(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOptionCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOptionCount());
        }

        public int GetOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOptionLockID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOptionLockID());
        }

        public int GetOptionLockIDs(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOptionLockIDs(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetOptionTermDescription(string alias)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOptionTermDescription(alias));
        }

        public int GetOptionTerms(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOptionTerms(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOutbarText(int index, ref object lst)
        {
            object local_lst = lst;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOutbarText(index, ref local_lst));
            lst = local_lst;
            return retVal;
        }

        public int GetOutdatedAllComponentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOutdatedAllComponentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOutdatedCableTypeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOutdatedCableTypeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOutdatedComponentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOutdatedComponentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetOutdatedSymbolTypeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOutdatedSymbolTypeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public double GetOuterDiameter(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOuterDiameter(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public double GetPanelAltGridSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPanelAltGridSize());
        }

        public double GetPanelGridSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPanelGridSize());
        }

        public double GetPanelTrapSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPanelTrapSize());
        }

        public int GetParentSheetIds(int flags, ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetParentSheetIds(flags, ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetPartExtension(string part, string vers, ref object xl, ref object yl, ref object xh, ref object yh, ref object shtcnt, ref object xp, ref object yp, ref object subcircuitType)
        {
            object local_xl = xl;
            object local_yl = yl;
            object local_xh = xh;
            object local_yh = yh;
            object local_shtcnt = shtcnt;
            object local_xp = xp;
            object local_yp = yp;
            object local_subcircuitType = subcircuitType;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPartExtension(part, vers, ref local_xl, ref local_yl, ref local_xh, ref local_yh, ref local_shtcnt, ref local_xp, ref local_yp, ref local_subcircuitType));
            xl = local_xl;
            yl = local_yl;
            xh = local_xh;
            yh = local_yh;
            shtcnt = local_shtcnt;
            xp = local_xp;
            yp = local_yp;
            subcircuitType = local_subcircuitType;
            return retVal;
        }

        public string GetPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPath());
        }

        public string GetPinViewSymbolForBlockConnectorPins()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinViewSymbolForBlockConnectorPins());
        }

        public string GetPinViewSymbolForConnectorPins()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinViewSymbolForConnectorPins());
        }

        public string GetPinViewSymbolForDevicePins()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPinViewSymbolForDevicePins());
        }

        public double GetPointGridSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPointGridSize());
        }

        public string GetPortNameSeparator()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPortNameSeparator());
        }

        public object GetProjectProperty(string what)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetProjectProperty(what));
        }

        public int GetProjectStructureLocking()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetProjectStructureLocking());
        }

        public int GetPurgeUnplacedPinViewsBeforeSave()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPurgeUnplacedPinViewsBeforeSave());
        }

        public int GetPurgeUnusedBeforeSave()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPurgeUnusedBeforeSave());
        }

        public int GetRedlinedGraphIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetRedlinedGraphIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetRedlinedGraphTextIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetRedlinedGraphTextIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetReloadAttributesOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetReloadAttributesOnUpdate());
        }

        public int GetRestoreChangedPinNamesOnUpdate()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRestoreChangedPinNamesOnUpdate());
        }

        public int GetResultText(int index, ref object lst)
        {
            object local_lst = lst;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetResultText(index, ref local_lst));
            lst = local_lst;
            return retVal;
        }

        public int GetRGBValue(int index, ref object r, ref object g, ref object b)
        {
            object local_r = r;
            object local_g = g;
            object local_b = b;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetRGBValue(index, ref local_r, ref local_g, ref local_b));
            r = local_r;
            g = local_g;
            b = local_b;
            return retVal;
        }

        public int GetRootModuleId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRootModuleId());
        }

        public double GetRulerGridSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRulerGridSize());
        }

        public string GetSchematicTypeDescription(int type)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSchematicTypeDescription(type));
        }

        public int GetSelectedAllDeviceCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedAllDeviceCount());
        }

        public int GetSelectedAllDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedAllDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedBlockCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedBlockCount());
        }

        public int GetSelectedBlockIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedBlockIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedBundleCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedBundleCount());
        }

        public int GetSelectedBundleIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedBundleIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedBusbarIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedBusbarIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedCableCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedCableCount());
        }

        public int GetSelectedCableIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedCableIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedConnectionCount(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedConnectionCount(flags));
        }

        public int GetSelectedConnectionIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedConnectionIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedConnectLineIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedConnectLineIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedConnectorCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedConnectorCount());
        }

        public int GetSelectedConnectorIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedConnectorIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedDeviceCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedDeviceCount());
        }

        public int GetSelectedDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedDimensionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedDimensionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedEmbeddedObjectIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedEmbeddedObjectIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedGraphCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedGraphCount());
        }

        public int GetSelectedGraphIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedGraphIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedNetSegmentCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedNetSegmentCount());
        }

        public int GetSelectedNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedSheetCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedSheetCount());
        }

        public int GetSelectedSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedSignalCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedSignalCount());
        }

        public int GetSelectedSignalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedSignalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedSymbolCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedSymbolCount());
        }

        public int GetSelectedSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedTerminalCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedTerminalCount());
        }

        public int GetSelectedTerminalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedTerminalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedTextCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedTextCount());
        }

        public int GetSelectedTextIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedTextIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public object GetSettingValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSettingValue(name));
        }

        public int GetSheetCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSheetCount());
        }

        public int GetSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSheetTreeStructure(ref object structarr, ref object info)
        {
            object local_structarr = structarr;
            object local_info = info;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSheetTreeStructure(ref local_structarr, ref local_info));
            structarr = local_structarr;
            info = local_info;
            return retVal;
        }

        public int GetShortcutPosition(ref object xpos, ref object ypos)
        {
            object local_xpos = xpos;
            object local_ypos = ypos;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetShortcutPosition(ref local_xpos, ref local_ypos));
            xpos = local_xpos;
            ypos = local_ypos;
            return retVal;
        }

        public int GetSignalClassIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSignalClassIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSignalCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalCount());
        }

        public int GetSignalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSignalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSignalStructureNodeId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSignalStructureNodeId());
        }

        public int GetStructureNodeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetStructureNodeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSupplyIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSupplyIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSymbolCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolCount());
        }

        public string GetSymbolForBlockConnectorsWithoutCompcode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolForBlockConnectorsWithoutCompcode());
        }

        public string GetSymbolForConnectorsWithoutCompcode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolForConnectorsWithoutCompcode());
        }

        public int GetSymbolIds(ref object ids, string symnam, int level, int view)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolIds(ref local_ids, symnam, level, view));
            ids = local_ids;
            return retVal;
        }

        public int GetSymbolTypeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolTypeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetTableSymbol()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTableSymbol());
        }

        public int GetTerminalCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTerminalCount());
        }

        public int GetTerminalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTerminalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTerminalPlanSettings(ref object settings)
        {
            object local_settings = settings;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTerminalPlanSettings(ref local_settings));
            settings = local_settings;
            return retVal;
        }

        public int GetTerminalPlanSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTerminalPlanSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTestpointIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTestpointIds(ref local_ids));
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

        public int GetTextTypes(out object textTypeDefinitions)
        {
            object local_textTypeDefinitions = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTextTypes(out local_textTypeDefinitions));
            textTypeDefinitions = local_textTypeDefinitions;
            return retVal;
        }

        public double GetTrapSize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTrapSize());
        }

        public int GetTreeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedAllDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedAllDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedAllDeviceIdsByFolder(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedAllDeviceIdsByFolder(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedBlockIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedBlockIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedBundleIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedBundleIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedBusbarIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedBusbarIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedCableIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedCableIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedConnectorIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedConnectorIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedExternalDocumentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedExternalDocumentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedExternalDocumentIdsByFolder(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedExternalDocumentIdsByFolder(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedSheetIdsByFolder(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedSheetIdsByFolder(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedSlotIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedSlotIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedStructureNodeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedStructureNodeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTreeSelectedTerminalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTreeSelectedTerminalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetTubeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTubeIds(ref local_ids));
            ids = local_ids;
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

        public int GetUnconnectCoresOnDelCline()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetUnconnectCoresOnDelCline());
        }

        public int GetUnplacedGroupIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetUnplacedGroupIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetUseBlockDesignation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetUseBlockDesignation());
        }

        public int GetUsePinAttributesOnAssign()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetUsePinAttributesOnAssign());
        }

        public int GetUsePinAttributesOnImport()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetUsePinAttributesOnImport());
        }

        public int GetVariantCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVariantCount());
        }

        public int GetVariantIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetVariantIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetViewSymbolForTerminalStrips()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetViewSymbolForTerminalStrips());
        }

        public int GetWireRange(ref object from, ref object to)
        {
            object local_from = from;
            object local_to = to;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetWireRange(ref local_from, ref local_to));
            from = local_from;
            to = local_to;
            return retVal;
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int HighlightAttribute(string attnam, string attvalue, int colour, double width)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HighlightAttribute(attnam, attvalue, colour, width));
        }

        public int ImportBoardLayout(string type, string file, int flags, string map, ref object exclusions)
        {
            object local_exclusions = exclusions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ImportBoardLayout(type, file, flags, map, ref local_exclusions));
            exclusions = local_exclusions;
            return retVal;
        }

        public int ImportDDSC(string file, int options, int level)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ImportDDSC(file, options, level));
        }

        public int ImportDrawing(string name, int unique, double posx, double posy)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ImportDrawing(name, unique, posx, posy));
        }

        public int ImportDrawingEx(string name, int unique, int flags, double posx, double posy)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ImportDrawingEx(name, unique, flags, posx, posy));
        }

        public int ImportDrawingForProjectGeneration(string name, int unique, uint flags, ref object substitutes, ref object allowedTexttypes, ref object allowedAttributenames, ref object resultArray, double posx, double posy)
        {
            object local_substitutes = substitutes;
            object local_allowedTexttypes = allowedTexttypes;
            object local_allowedAttributenames = allowedAttributenames;
            object local_resultArray = resultArray;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ImportDrawingForProjectGeneration(name, unique, flags, ref local_substitutes, ref local_allowedTexttypes, ref local_allowedAttributenames, ref local_resultArray, posx, posy));
            substitutes = local_substitutes;
            allowedTexttypes = local_allowedTexttypes;
            allowedAttributenames = local_allowedAttributenames;
            resultArray = local_resultArray;
            return retVal;
        }

        public int ImportELCAD(ref object parameters)
        {
            object local_parameters = parameters;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ImportELCAD(ref local_parameters));
            parameters = local_parameters;
            return retVal;
        }

        public int ImportForeignProject(ref object parameters)
        {
            object local_parameters = parameters;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ImportForeignProject(ref local_parameters));
            parameters = local_parameters;
            return retVal;
        }

        public int ImportMultiuser(string file, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ImportMultiuser(file, name));
        }

        public int ImportPanlib(ref object parameters)
        {
            object local_parameters = parameters;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ImportPanlib(ref local_parameters));
            parameters = local_parameters;
            return retVal;
        }

        public int ImportRuplan(ref object parameters)
        {
            object local_parameters = parameters;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ImportRuplan(ref local_parameters));
            parameters = local_parameters;
            return retVal;
        }

        public int ImportWESPE(ref object parameters)
        {
            object local_parameters = parameters;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ImportWESPE(ref local_parameters));
            parameters = local_parameters;
            return retVal;
        }

        public int IsChanged()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsChanged());
        }

        public int IsFileReadonly()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFileReadonly());
        }

        public int IsMultiuserProject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsMultiuserProject());
        }

        public int IsOfflineId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsOfflineId(id));
        }

        public int IsVariantStructurePasswordProtected()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsVariantStructurePasswordProtected());
        }

        public int JumpToID(int jumpid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.JumpToID(jumpid));
        }

        public int LoadLevelConfiguration(string file)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadLevelConfiguration(file));
        }

        public int LoadOptionStructure(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadOptionStructure(filename));
        }

        public int LoadOptionStructureEx(string filename, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadOptionStructureEx(filename, flags));
        }

        public int LoadPart(string name, string version, int unique)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadPart(name, version, unique));
        }

        public int LoadSignalStructure(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadSignalStructure(filename));
        }

        public int LoadStructureTemplate(string structure_file)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadStructureTemplate(structure_file));
        }

        public int LoadTableConfiguration(string file, int table)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadTableConfiguration(file, table));
        }

        public int LockVariantStructure(string password)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LockVariantStructure(password));
        }

        public int New(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.New(name));
        }

        public int NewMultiuser(string name, string description, string filename, int checkin, int unlock)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.NewMultiuser(name, description, filename, checkin, unlock));
        }

        public int Open(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Open(name));
        }

        public int OpenGranularDesignProject(string folder, int options)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.OpenGranularDesignProject(folder, options));
        }

        public int OpenMultiuser(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.OpenMultiuser(name));
        }

        public int OptimizeMemory(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.OptimizeMemory(flags));
        }

        public int OverwriteMultiuser(string name, string filename, int unlock)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.OverwriteMultiuser(name, filename, unlock));
        }

        public int PlacePartInteractively(string name, string version, out object x, out object y, out object rot)
        {
            object local_x = default;
            object local_y = default;
            object local_rot = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PlacePartInteractively(name, version, out local_x, out local_y, out local_rot));
            x = local_x;
            y = local_y;
            rot = local_rot;
            return retVal;
        }

        public int PlacePartInteractivelyEx(string name, string version, int flags, out object x, out object y, out object rot)
        {
            object local_x = default;
            object local_y = default;
            object local_rot = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PlacePartInteractivelyEx(name, version, flags, out local_x, out local_y, out local_rot));
            x = local_x;
            y = local_y;
            rot = local_rot;
            return retVal;
        }

        public int PrintOut(double scale, ref object shtids)
        {
            object local_shtids = shtids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.PrintOut(scale, ref local_shtids));
            shtids = local_shtids;
            return retVal;
        }

        public int PurgeUnplacedPinViews()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PurgeUnplacedPinViews());
        }

        public int PurgeUnused()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PurgeUnused());
        }

        public int QuitFrameTransaction()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.QuitFrameTransaction());
        }

        public int RecalcWireLength(string bundlesequence_attribute, string length_attribute)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.RecalcWireLength(bundlesequence_attribute, length_attribute));
        }

        public int ReloadSettings(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ReloadSettings(filename));
        }

        public int RemoveAccessControlInformation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.RemoveAccessControlInformation());
        }

        public int RemoveUndoInformation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.RemoveUndoInformation());
        }

        public int RenameMultiuser(string oldname, string newname, string newdesc)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.RenameMultiuser(oldname, newname, newdesc));
        }

        public int RepairCheckExtended(int mode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.RepairCheckExtended(mode));
        }

        public int ResetAttributeHighWaterMark(string attname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetAttributeHighWaterMark(attname));
        }

        public int ResetHighlight()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetHighlight());
        }

        public int ResetHighlightAttribute(string attnam, string attvalue)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetHighlightAttribute(attnam, attvalue));
        }

        public int ResetSelection()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetSelection());
        }

        public int RestoreOptionVisibility(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.RestoreOptionVisibility(filename));
        }

        public int RestoreVariantVisibility(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.RestoreVariantVisibility(filename));
        }

        public int RunUnitTests(ref object tests, out object fixtures, out object testcases, out object succeeded, out object failed, out object inconclusive)
        {
            object local_tests = tests;
            object local_fixtures = default;
            object local_testcases = default;
            object local_succeeded = default;
            object local_failed = default;
            object local_inconclusive = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.RunUnitTests(ref local_tests, out local_fixtures, out local_testcases, out local_succeeded, out local_failed, out local_inconclusive));
            tests = local_tests;
            fixtures = local_fixtures;
            testcases = local_testcases;
            succeeded = local_succeeded;
            failed = local_failed;
            inconclusive = local_inconclusive;
            return retVal;
        }

        public int Save()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Save());
        }

        public int SaveAs(string name, int compressed)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveAs(name, compressed));
        }

        public int SaveAsGranularDesignProject(string folder, int options)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveAsGranularDesignProject(folder, options));
        }

        public int SaveLevelConfiguration(string file)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveLevelConfiguration(file));
        }

        public int SaveMultiuser(uint mode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveMultiuser(mode));
        }

        public int SaveOptionStructure(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveOptionStructure(filename));
        }

        public int SaveProjectWithoutVariants(string name, int compressed)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveProjectWithoutVariants(name, compressed));
        }

        public int SaveSheetsAsSingleUser(string name, ref object shtids, int compressed, string completeName, int completeCompressed)
        {
            object local_shtids = shtids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SaveSheetsAsSingleUser(name, ref local_shtids, compressed, completeName, completeCompressed));
            shtids = local_shtids;
            return retVal;
        }

        public int SaveSheetsAsSingleUserEx(string name, ref object shtids, string completeName, int flags)
        {
            object local_shtids = shtids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SaveSheetsAsSingleUserEx(name, ref local_shtids, completeName, flags));
            shtids = local_shtids;
            return retVal;
        }

        public int SaveTableConfiguration(string file, int table)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveTableConfiguration(file, table));
        }

        public int SetActiveOptionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetActiveOptionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int SetActiveSheetTreeID(int treeid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetActiveSheetTreeID(treeid));
        }

        public int SetActiveVariantId(int vari)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetActiveVariantId(vari));
        }

        public int SetAddDeviceDesignationOfConnectionTarget(int bMerge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAddDeviceDesignationOfConnectionTarget(bMerge));
        }

        public double SetAltGridSize(double newsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAltGridSize(newsize));
        }

        public string SetAssignmentSeparator(string newsep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAssignmentSeparator(newsep));
        }

        public void SetAssignmentSuffixSeparator(string newsep)
        {
            StaThreadExecutor.Instance.Execute(() => _raw.SetAssignmentSuffixSeparator(newsep));
        }

        public int SetAttributeNotInheritable(string attnam, int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeNotInheritable(attnam, newval));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetBlockCopyGraphicInSplit(int copy)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockCopyGraphicInSplit(copy));
        }

        public int SetBlockReferenceTextDirection(int newdir)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockReferenceTextDirection(newdir));
        }

        public double SetBlockReferenceTextGap(double newgap)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockReferenceTextGap(newgap));
        }

        public int SetBlockReferenceTextLevel(int newlev)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockReferenceTextLevel(newlev));
        }

        public int SetBlockReferenceTextRotate(int rotate)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockReferenceTextRotate(rotate));
        }

        public int SetBlockReferenceType(int newtype)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockReferenceType(newtype));
        }

        public int SetBlockTextAlignment(int newalign)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockTextAlignment(newalign));
        }

        public int SetBlockTextColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockTextColour(newcol));
        }

        public string SetBlockTextFont(string newfont)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockTextFont(newfont));
        }

        public int SetBlockTextRatio(int newratio)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockTextRatio(newratio));
        }

        public double SetBlockTextSize(double newsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockTextSize(newsize));
        }

        public int SetBlockTextStyle(int newstyle)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBlockTextStyle(newstyle));
        }

        public int SetBusLineColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBusLineColour(newcol));
        }

        public int SetBusLineLevel(int newlev)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBusLineLevel(newlev));
        }

        public int SetBusLineStyle(int newstl)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBusLineStyle(newstl));
        }

        public int SetBusLineWidth(double newwid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetBusLineWidth(newwid));
        }

        public int SetCadstarCrossProbing(int probe)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCadstarCrossProbing(probe));
        }

        public int SetChanged(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetChanged(newval));
        }

        public double SetConnectionInclinationAngle(double angle)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetConnectionInclinationAngle(angle));
        }

        public double SetConnectionInclinationDistance(double destination)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetConnectionInclinationDistance(destination));
        }

        public int SetConnectionMode(int mode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetConnectionMode(mode));
        }

        public int SetConnectionTargetFormat(int txttyp, int flags, string entire_prefix, string entire_suffix, int count, ref object prefix, ref object name, ref object funct)
        {
            object local_prefix = prefix;
            object local_name = name;
            object local_funct = funct;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetConnectionTargetFormat(txttyp, flags, entire_prefix, entire_suffix, count, ref local_prefix, ref local_name, ref local_funct));
            prefix = local_prefix;
            name = local_name;
            funct = local_funct;
            return retVal;
        }

        public int SetConnectorPinTerminalParameterOverwriteModelPin(int bValue)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetConnectorPinTerminalParameterOverwriteModelPin(bValue));
        }

        public int SetConnectorSymbolFormat(ref object texttypes, ref object dispflags)
        {
            object local_texttypes = texttypes;
            object local_dispflags = dispflags;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetConnectorSymbolFormat(ref local_texttypes, ref local_dispflags));
            texttypes = local_texttypes;
            dispflags = local_dispflags;
            return retVal;
        }

        public int SetCreateUniqueSheetNames(int uniquenames)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCreateUniqueSheetNames(uniquenames));
        }

        public int SetDefaultHoseTube(string HoseTube)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDefaultHoseTube(HoseTube));
        }

        public int SetDefaultJumper(string jumpergroup, string jumpername)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDefaultJumper(jumpergroup, jumpername));
        }

        public int SetDefaultWire(string wiregroup, string wirename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDefaultWire(wiregroup, wirename));
        }

        public int SetDeleteCoresOnDelCline(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeleteCoresOnDelCline(newval));
        }

        public int SetDeletePinAttributesOnUnplace(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeletePinAttributesOnUnplace(newval));
        }

        public int SetDeleteSignalOnDelCline(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeleteSignalOnDelCline(newval));
        }

        public int SetDetermineConnectorSymbol(int determine)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDetermineConnectorSymbol(determine));
        }

        public int SetDetermineConnectorViewSymbol(int determine)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDetermineConnectorViewSymbol(determine));
        }

        public string SetDeviceNameSeparator(string newsep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceNameSeparator(newsep));
        }

        public void SetDeviceNameSuffixSeparator(string newsep)
        {
            StaThreadExecutor.Instance.Execute(() => _raw.SetDeviceNameSuffixSeparator(newsep));
        }

        public string SetDisplayAltCompCode(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayAltCompCode(newval));
        }

        public int SetDisplayAppendFormboardNameToDeviceName(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayAppendFormboardNameToDeviceName(newval));
        }

        public int SetDisplayConnectionMode(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayConnectionMode(value));
        }

        public int SetDisplayConnectionType(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayConnectionType(newval));
        }

        public int SetDisplayConnectPoints(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayConnectPoints(newval));
        }

        public int SetDisplayDuctDockingPoints(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayDuctDockingPoints(newval));
        }

        public int SetDisplayDuctFillSize(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayDuctFillSize(newval));
        }

        public int SetDisplayFormboardEffectiveDirection(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayFormboardEffectiveDirection(newval));
        }

        public int SetDisplayFormboardMarkDifferenLength(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayFormboardMarkDifferenLength(newval));
        }

        public int SetDisplayFormboardNodes(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayFormboardNodes(newval));
        }

        public int SetDisplayFormboardTableSubsidiaryLines(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayFormboardTableSubsidiaryLines(newval));
        }

        public int SetDisplayFormboardUnconnectedCores(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayFormboardUnconnectedCores(newval));
        }

        public int SetDisplayIntExtRepresentation(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayIntExtRepresentation(newval));
        }

        public int SetDisplayMILStandard(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayMILStandard(newval));
        }

        public int SetDisplayOptionsAll(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayOptionsAll(newval));
        }

        public int SetDisplayOptionsColoured(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayOptionsColoured(newval));
        }

        public int SetDisplayOptionsNone(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayOptionsNone(newval));
        }

        public int SetDisplayRotatedTextAccStandard(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayRotatedTextAccStandard(newval));
        }

        public int SetDisplayUnconnectedNodes(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayUnconnectedNodes(newval));
        }

        public int SetDisplayViewNumbers(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayViewNumbers(newval));
        }

        public int SetDynamicSymbolOriginInUpperLeft(int bTopLeft)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDynamicSymbolOriginInUpperLeft(bTopLeft));
        }

        public int SetExclusiveMode(int mode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetExclusiveMode(mode));
        }

        public int SetExportWithCablesAndWires(int cablesandwires)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetExportWithCablesAndWires(cablesandwires));
        }

        public int SetExportWithCablesAndWiresOption(int option)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetExportWithCablesAndWiresOption(option));
        }

        public int SetFieldHatchColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFieldHatchColour(newcol));
        }

        public double SetFieldHatchLineDistance(double newdist)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFieldHatchLineDistance(newdist));
        }

        public double SetFieldHatchLineWidth(double newwid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFieldHatchLineWidth(newwid));
        }

        public int SetFieldHatchPattern(int newpat)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFieldHatchPattern(newpat));
        }

        public int SetFieldOriginInUpperLeft(int bTopLeft)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFieldOriginInUpperLeft(bTopLeft));
        }

        public int SetFieldOutlineColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFieldOutlineColour(newcol));
        }

        public int SetFieldOutlineStyle(int newstyle)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFieldOutlineStyle(newstyle));
        }

        public double SetFieldOutlineWidth(double width)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFieldOutlineWidth(width));
        }

        public string SetFieldTextTemplate(string newname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFieldTextTemplate(newname));
        }

        public int SetFormboardAutoplaceTableSymbol(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFormboardAutoplaceTableSymbol(newval));
        }

        public int SetFormboardAutorotateConnectorSymbols(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFormboardAutorotateConnectorSymbols(newval));
        }

        public int SetFormboardBranchAngleStep(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFormboardBranchAngleStep(newval));
        }

        public double SetGapToPlaceSinglePins(double new_gap)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGapToPlaceSinglePins(new_gap));
        }

        public int SetGeneratedWireNameFormat(string prefix, string separator, string postfix, ref object attPrefix, ref object attType, ref object attname)
        {
            object local_attPrefix = attPrefix;
            object local_attType = attType;
            object local_attname = attname;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetGeneratedWireNameFormat(prefix, separator, postfix, ref local_attPrefix, ref local_attType, ref local_attname));
            attPrefix = local_attPrefix;
            attType = local_attType;
            attname = local_attname;
            return retVal;
        }

        public int SetGeneratedWireNameFormatEx(ref object attPrefix, ref object attType, ref object attname)
        {
            object local_attPrefix = attPrefix;
            object local_attType = attType;
            object local_attname = attname;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetGeneratedWireNameFormatEx(ref local_attPrefix, ref local_attType, ref local_attname));
            attPrefix = local_attPrefix;
            attType = local_attType;
            attname = local_attname;
            return retVal;
        }

        public int SetGetterOptionHandlingMode(int mode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGetterOptionHandlingMode(mode));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetGraphArrows(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphArrows(value));
        }

        public int SetGraphColour(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphColour(value));
        }

        public int SetGraphHatchColour(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphHatchColour(value));
        }

        public double SetGraphHatchDistance(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphHatchDistance(value));
        }

        public int SetGraphHatchPattern(int value, double angle1, double angle2)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphHatchPattern(value, angle1, angle2));
        }

        public int SetGraphHatchStyle(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphHatchStyle(value));
        }

        public double SetGraphHatchWidth(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphHatchWidth(value));
        }

        public int SetGraphLevel(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphLevel(value));
        }

        public int SetGraphStyle(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphStyle(value));
        }

        public int SetGraphTextColour(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphTextColour(value));
        }

        public string SetGraphTextFontName(string newname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphTextFontName(newname));
        }

        public double SetGraphTextHeight(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphTextHeight(value));
        }

        public int SetGraphTextLevel(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphTextLevel(value));
        }

        public int SetGraphTextMode(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphTextMode(value));
        }

        public double SetGraphTextSize(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphTextSize(value));
        }

        public int SetGraphTextStyle(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphTextStyle(value));
        }

        public double SetGraphWidth(double value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGraphWidth(value));
        }

        public double SetGridSize(double newsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGridSize(newsize));
        }

        public int SetHighlightColour(int colour)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHighlightColour(colour));
        }

        public int SetHighlightKeep(int keep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHighlightKeep(keep));
        }

        public double SetHighlightLineWidth(double width)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetHighlightLineWidth(width));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetIEC61346Setting(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetIEC61346Setting(newval));
        }

        public string SetImportItemDesignationSuffix(string newsuffix)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImportItemDesignationSuffix(newsuffix));
        }

        public int SetImportMergeAttributes(int merge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImportMergeAttributes(merge));
        }

        public int SetImportMergeConnectLines(int merge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImportMergeConnectLines(merge));
        }

        public int SetImportMergeExistingAssemblies(int merge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImportMergeExistingAssemblies(merge));
        }

        public int SetImportMergeExistingDevices(int merge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImportMergeExistingDevices(merge));
        }

        public int SetImportMergeExistingTerminalStrips(int merge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImportMergeExistingTerminalStrips(merge));
        }

        public int SetImportMergeOptions(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImportMergeOptions(newval));
        }

        public int SetImportUseItemDesignationSuffix(int use)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImportUseItemDesignationSuffix(use));
        }

        public int SetInvertDisplayColour(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetInvertDisplayColour(value));
        }

        public int SetKeepActiveConnectorPinTerminalOnUpdate(int keep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetKeepActiveConnectorPinTerminalOnUpdate(keep));
        }

        public int SetKeepActiveCounterpartOnUpdate(int keep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetKeepActiveCounterpartOnUpdate(keep));
        }

        public int SetKeepActiveFittingOnUpdate(int keep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetKeepActiveFittingOnUpdate(keep));
        }

        public int SetKeepConnectorSymbolsOnUpdate(int keep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetKeepConnectorSymbolsOnUpdate(keep));
        }

        public int SetKeepModelTextParametersOnUpdate(int keep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetKeepModelTextParametersOnUpdate(keep));
        }

        public int SetKeepModelTextVisibilityOnUpdate(int keep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetKeepModelTextVisibilityOnUpdate(keep));
        }

        public int SetKeepSymbolTextParametersOnUpdate(int keep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetKeepSymbolTextParametersOnUpdate(keep));
        }

        public int SetKeepSymbolTextVisibilityOnUpdate(int keep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetKeepSymbolTextVisibilityOnUpdate(keep));
        }

        public int SetLanguages(ref object languages)
        {
            object local_languages = languages;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetLanguages(ref local_languages));
            languages = local_languages;
            return retVal;
        }

        public int SetLevel(int lev, int onoff)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLevel(lev, onoff));
        }

        public int SetLevels(ref object symarr, ref object sgraarr, ref object stxtarr, ref object semtarr, ref object graarr, ref object txtarr, ref object cxarr, ref object names)
        {
            object local_symarr = symarr;
            object local_sgraarr = sgraarr;
            object local_stxtarr = stxtarr;
            object local_semtarr = semtarr;
            object local_graarr = graarr;
            object local_txtarr = txtarr;
            object local_cxarr = cxarr;
            object local_names = names;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetLevels(ref local_symarr, ref local_sgraarr, ref local_stxtarr, ref local_semtarr, ref local_graarr, ref local_txtarr, ref local_cxarr, ref local_names));
            symarr = local_symarr;
            sgraarr = local_sgraarr;
            stxtarr = local_stxtarr;
            semtarr = local_semtarr;
            graarr = local_graarr;
            txtarr = local_txtarr;
            cxarr = local_cxarr;
            names = local_names;
            return retVal;
        }

        public int SetLineColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineColour(newcol));
        }

        public int SetLineLevel(int newlev)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineLevel(newlev));
        }

        public int SetLineStyle(int newstl)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineStyle(newstl));
        }

        public int SetLineWidth(double newwid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLineWidth(newwid));
        }

        public string SetLocationSeparator(string newsep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLocationSeparator(newsep));
        }

        public void SetLocationSuffixSeparator(string newsep)
        {
            StaThreadExecutor.Instance.Execute(() => _raw.SetLocationSuffixSeparator(newsep));
        }

        public int SetMeasure(string measure)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMeasure(measure));
        }

        public int SetMergeAlphanumericReferences(int bMerge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMergeAlphanumericReferences(bMerge));
        }

        public int SetMergeSheetReferences(int bMerge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMergeSheetReferences(bMerge));
        }

        public int SetMergeUsingExactCoreConnectionOnImport(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMergeUsingExactCoreConnectionOnImport(newval));
        }

        public int SetMILGraphicLineColour(int newcol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMILGraphicLineColour(newcol));
        }

        public int SetMILGraphicLineStyle(int newstyle)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMILGraphicLineStyle(newstyle));
        }

        public double SetMILGraphicLineWidth(double width)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMILGraphicLineWidth(width));
        }

        public int SetNetSegmentAttributeSplittingRule(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetNetSegmentAttributeSplittingRule(newval));
        }

        public int SetNetSegmentLengthSplittingRule(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetNetSegmentLengthSplittingRule(newval));
        }

        public int SetOptionExpressions(ref object itemarray, ref object expressions)
        {
            object local_itemarray = itemarray;
            object local_expressions = expressions;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetOptionExpressions(ref local_itemarray, ref local_expressions));
            itemarray = local_itemarray;
            expressions = local_expressions;
            return retVal;
        }

        public double SetPanelAltGridSize(double newsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelAltGridSize(newsize));
        }

        public double SetPanelGridSize(double newsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelGridSize(newsize));
        }

        public double SetPanelTrapSize(double newsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelTrapSize(newsize));
        }

        public int SetPinViewSymbolForBlockConnectorPins(string new_sym)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPinViewSymbolForBlockConnectorPins(new_sym));
        }

        public int SetPinViewSymbolForConnectorPins(string new_sym)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPinViewSymbolForConnectorPins(new_sym));
        }

        public int SetPinViewSymbolForDevicePins(string new_sym)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPinViewSymbolForDevicePins(new_sym));
        }

        public double SetPointGridSize(double newsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPointGridSize(newsize));
        }

        public string SetPortNameSeparator(string newsep)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPortNameSeparator(newsep));
        }

        public int SetProjectStructureLocking(int @lock)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetProjectStructureLocking(@lock));
        }

        public int SetPurgeUnplacedPinViewsBeforeSave(int purge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPurgeUnplacedPinViewsBeforeSave(purge));
        }

        public int SetPurgeUnusedBeforeSave(int purge)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPurgeUnusedBeforeSave(purge));
        }

        public int SetReloadAttributesOnUpdate(int reload)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetReloadAttributesOnUpdate(reload));
        }

        public int SetRestoreChangedPinNamesOnUpdate(int restore)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRestoreChangedPinNamesOnUpdate(restore));
        }

        public int SetRGBValue(ref object index, ref object r, ref object g, ref object b)
        {
            object local_index = index;
            object local_r = r;
            object local_g = g;
            object local_b = b;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetRGBValue(ref local_index, ref local_r, ref local_g, ref local_b));
            index = local_index;
            r = local_r;
            g = local_g;
            b = local_b;
            return retVal;
        }

        public double SetRulerGridSize(double newsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetRulerGridSize(newsize));
        }

        public object SetSettingValue(string name, ref object value)
        {
            object local_value = value;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetSettingValue(name, ref local_value));
            value = local_value;
            return retVal;
        }

        public int SetSheetTreeStructure(ref object structarr, ref object info)
        {
            object local_structarr = structarr;
            object local_info = info;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetSheetTreeStructure(ref local_structarr, ref local_info));
            structarr = local_structarr;
            info = local_info;
            return retVal;
        }

        public int SetSymbolForBlockConnectorsWithoutCompcode(string new_sym)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSymbolForBlockConnectorsWithoutCompcode(new_sym));
        }

        public int SetSymbolForConnectorsWithoutCompcode(string new_sym)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSymbolForConnectorsWithoutCompcode(new_sym));
        }

        public string SetTableSymbol(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTableSymbol(newval));
        }

        public int SetTerminalPlanSettings(ref object settings)
        {
            object local_settings = settings;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetTerminalPlanSettings(ref local_settings));
            settings = local_settings;
            return retVal;
        }

        public double SetTrapSize(double newsize)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTrapSize(newsize));
        }

        public int SetUnconnectCoresOnDelCline(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUnconnectCoresOnDelCline(newval));
        }

        public int SetUnlockPassword(string oldval, string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUnlockPassword(oldval, newval));
        }

        public int SetUnlockVariantStructurePassword(string oldval, string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUnlockVariantStructurePassword(oldval, newval));
        }

        public int SetUseBlockDesignation(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUseBlockDesignation(newval));
        }

        public int SetUsePinAttributesOnAssign(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUsePinAttributesOnAssign(newval));
        }

        public int SetUsePinAttributesOnImport(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUsePinAttributesOnImport(newval));
        }

        public int SetViewSymbolForTerminalStrips(string new_sym)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetViewSymbolForTerminalStrips(new_sym));
        }

        public int SetWireRange(int from, int to)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetWireRange(from, to));
        }

        public int ShowPartPreview(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ShowPartPreview(name));
        }

        public int StartFrameTransaction()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.StartFrameTransaction());
        }

        public int StoreOptionVisibility(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.StoreOptionVisibility(filename));
        }

        public int StoreVariantVisibility(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.StoreVariantVisibility(filename));
        }

        public int UndoAfterExecution(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UndoAfterExecution(newval));
        }

        public int UnlockVariantStructure(string password)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnlockVariantStructure(password));
        }

        public int UpdateAllComponents(int withSymbol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateAllComponents(withSymbol));
        }

        public int UpdateAllParts()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateAllParts());
        }

        public int UpdateAllSubCircuits()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateAllSubCircuits());
        }

        public int UpdateAllSymbols()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateAllSymbols());
        }

        public int UpdateAllTerminalPlans()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateAllTerminalPlans());
        }

        public int UpdateAutoShtrefs()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateAutoShtrefs());
        }

        public int UpdateCompleteProject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateCompleteProject());
        }

        public int UpdateComponent(string cmpnam, int withSymbol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateComponent(cmpnam, withSymbol));
        }

        public int UpdateComponentAttributes(string name, string version)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateComponentAttributes(name, version));
        }

        public int UpdateComponentVersion(string name, string version, int withSymbol)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateComponentVersion(name, version, withSymbol));
        }

        public int UpdateConfiguration()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateConfiguration());
        }

        public int UpdateConnectionTargets()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateConnectionTargets());
        }

        public int UpdateCores()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateCores());
        }

        public int UpdateLanguageDatabase()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateLanguageDatabase());
        }

        public int UpdateMultiuser()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateMultiuser());
        }

        public int UpdatePart(string filename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdatePart(filename));
        }

        public int UpdateSubCircuit(string cmpnam)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateSubCircuit(cmpnam));
        }

        public int UpdateSymbol(string symnam)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateSymbol(symnam));
        }

        public int UpdateTextsInProject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateTextsInProject());
        }

        public int Verify(int mode, string logfile)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Verify(mode, logfile));
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

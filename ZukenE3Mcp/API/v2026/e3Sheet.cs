using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Sheet : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Sheet _raw;
        private bool _disposed;

        public e3Sheet(Zuken.E3.Interop.e3Sheet raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Sheet RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int AlignObjects(int reference, ref object ids, int mode)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AlignObjects(reference, ref local_ids, mode));
            ids = local_ids;
            return retVal;
        }

        public int checkin(int unlock, ref object sheetids)
        {
            object local_sheetids = sheetids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.checkin(unlock, ref local_sheetids));
            sheetids = local_sheetids;
            return retVal;
        }

        public int CheckInAll(int unlock)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CheckInAll(unlock));
        }

        public int CheckOut(int @lock, ref object sheetids)
        {
            object local_sheetids = sheetids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CheckOut(@lock, ref local_sheetids));
            sheetids = local_sheetids;
            return retVal;
        }

        public int CheckOutAll(int @lock)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CheckOutAll(@lock));
        }

        public int CheckoutReadonlyReferencedSheets()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CheckoutReadonlyReferencedSheets());
        }

        public int Create(int modi, string name, string symbol, int position, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(modi, name, symbol, position, before));
        }

        public int CreateBoard(int brdi, string name, string symbol, int position, int before, double refx, double refy, double refscale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateBoard(brdi, name, symbol, position, before, refx, refy, refscale));
        }

        public int CreateFormboard(int modi, string name, string symbol, int position, int before, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateFormboard(modi, name, symbol, position, before, flags));
        }

        public int CreateFormboardEx(int modi, string name, string symbol, int position, int before, double refx, double refy, double refscale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateFormboardEx(modi, name, symbol, position, before, refx, refy, refscale));
        }

        public int CreateFunctionalDesign(int modi, string name, string symbol, int position, int before, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateFunctionalDesign(modi, name, symbol, position, before, flags));
        }

        public int CreatePanel(int modi, string name, string symbol, int position, int before, double refx, double refy, double refscale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreatePanel(modi, name, symbol, position, before, refx, refy, refscale));
        }

        public int CreateTopology(int modi, string name, string symbol, int position, int before, double refscale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateTopology(modi, name, symbol, position, before, refscale));
        }

        public int CreateTopologyEx(int modi, string name, string symbol, int position, int before, double refx, double refy, double refscale, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateTopologyEx(modi, name, symbol, position, before, refx, refy, refscale, flags));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int Display()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Display());
        }

        public int DisplayEx(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DisplayEx(flags));
        }

        public int Export(string format, int version, string file, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Export(format, version, file, flags));
        }

        public int ExportImage(string format, int version, string file, int dpi, int compressionmode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportImage(format, version, file, dpi, compressionmode));
        }

        public int ExportImageArea(string format, int version, string file, double xl, double yl, double xr, double yr, int width, int height, int clrdepth, int gray, int dpiX, int dpiY, int compressionmode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportImageArea(format, version, file, xl, yl, xr, yr, width, height, clrdepth, gray, dpiX, dpiY, compressionmode));
        }

        public int ExportImageSelection(string format, int version, string file, int percentage, int width, int height, int clrdepth, int gray, int dpiX, int dpiY, int compressionmode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ExportImageSelection(format, version, file, percentage, width, height, clrdepth, gray, dpiX, dpiY, compressionmode));
        }

        public int Get2DViewDisplayInOriginalOrientation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Get2DViewDisplayInOriginalOrientation());
        }

        public int Get2DViewSheetDisplayOnlyBorder()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Get2DViewSheetDisplayOnlyBorder());
        }

        public int Get2DViewSheetDisplaySlots()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Get2DViewSheetDisplaySlots());
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

        public string GetAssignment()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAssignment());
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

        public int GetBaseId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBaseId());
        }

        public string GetCharacteristic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCharacteristic());
        }

        public int GetContentModified()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetContentModified());
        }

        public int GetDimensionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDimensionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetDisplayModelViewAtPosition(out object view_distance, int flags)
        {
            object local_view_distance = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDisplayModelViewAtPosition(out local_view_distance, flags));
            view_distance = local_view_distance;
            return retVal;
        }

        public int GetDrawingArea(ref object xmin, ref object ymin, ref object xmax, ref object ymax)
        {
            object local_xmin = xmin;
            object local_ymin = ymin;
            object local_xmax = xmax;
            object local_ymax = ymax;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDrawingArea(ref local_xmin, ref local_ymin, ref local_xmax, ref local_ymax));
            xmin = local_xmin;
            ymin = local_ymin;
            xmax = local_xmax;
            ymax = local_ymax;
            return retVal;
        }

        public int GetDXFSize(string filename, string font, ref object dx, ref object dy, ref object scale)
        {
            object local_dx = dx;
            object local_dy = dy;
            object local_scale = scale;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDXFSize(filename, font, ref local_dx, ref local_dy, ref local_scale));
            dx = local_dx;
            dy = local_dy;
            scale = local_scale;
            return retVal;
        }

        public int GetEmbeddedObjectIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetEmbeddedObjectIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetEmbeddedSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetEmbeddedSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetFormat()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFormat());
        }

        public int GetGetterOptionHandlingMode()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGetterOptionHandlingMode());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetGraphCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGraphCount());
        }

        public int GetGraphIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGraphIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetGroupIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetGroupIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetGUID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGUID());
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

        public int GetInsideGraphIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsideGraphIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetInsideNetSegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsideNetSegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetInsidePanelConnectionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsidePanelConnectionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetInsideSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetInsideSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetLocation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocation());
        }

        public int GetModuleCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetModuleCount());
        }

        public int GetModuleIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetModuleIds(ref local_ids));
            ids = local_ids;
            return retVal;
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

        public int GetOpenNetsegmentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOpenNetsegmentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetOwner()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOwner());
        }

        public int GetOwners(ref object owners)
        {
            object local_owners = owners;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOwners(ref local_owners));
            owners = local_owners;
            return retVal;
        }

        public int GetPanelConnectionIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPanelConnectionIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetPanelRegion(ref object xoff, ref object yoff, ref object scale)
        {
            object local_xoff = xoff;
            object local_yoff = yoff;
            object local_scale = scale;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPanelRegion(ref local_xoff, ref local_yoff, ref local_scale));
            xoff = local_xoff;
            yoff = local_yoff;
            scale = local_scale;
            return retVal;
        }

        public int GetParentSheetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParentSheetId());
        }

        public string GetProduct()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetProduct());
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

        public int GetRegionArea(ref object xmin, ref object ymin, ref object xmax, ref object ymax)
        {
            object local_xmin = xmin;
            object local_ymin = ymin;
            object local_xmax = xmax;
            object local_ymax = ymax;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetRegionArea(ref local_xmin, ref local_ymin, ref local_xmax, ref local_ymax));
            xmin = local_xmin;
            ymin = local_ymin;
            xmax = local_xmax;
            ymax = local_ymax;
            return retVal;
        }

        public int GetSchematicTypes(ref object types)
        {
            object local_types = types;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSchematicTypes(ref local_types));
            types = local_types;
            return retVal;
        }

        public int GetSharedIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSharedIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSheetRegion(ref object xoff, ref object yoff, ref object scale)
        {
            object local_xoff = xoff;
            object local_yoff = yoff;
            object local_scale = scale;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSheetRegion(ref local_xoff, ref local_yoff, ref local_scale));
            xoff = local_xoff;
            yoff = local_yoff;
            scale = local_scale;
            return retVal;
        }

        public int GetSlotIdsFrom2DView(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSlotIdsFrom2DView(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSymbolCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolCount());
        }

        public int GetSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolIds(ref local_ids));
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

        public int GetTopologyRegion(ref object xoff, ref object yoff, ref object scale)
        {
            object local_xoff = xoff;
            object local_yoff = yoff;
            object local_scale = scale;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTopologyRegion(ref local_xoff, ref local_yoff, ref local_scale));
            xoff = local_xoff;
            yoff = local_yoff;
            scale = local_scale;
            return retVal;
        }

        public int GetValidCharacteristics(ref object characteristics)
        {
            object local_characteristics = characteristics;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetValidCharacteristics(ref local_characteristics));
            characteristics = local_characteristics;
            return retVal;
        }

        public int GetVisibleArea(ref object xmin, ref object ymin, ref object xmax, ref object ymax)
        {
            object local_xmin = xmin;
            object local_ymin = ymin;
            object local_xmax = xmax;
            object local_ymax = ymax;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetVisibleArea(ref local_xmin, ref local_ymin, ref local_xmax, ref local_ymax));
            xmin = local_xmin;
            ymin = local_ymin;
            xmax = local_xmax;
            ymax = local_ymax;
            return retVal;
        }

        public int GetWorkingArea(ref object xmin, ref object ymin, ref object xmax, ref object ymax)
        {
            object local_xmin = xmin;
            object local_ymin = ymin;
            object local_xmax = xmax;
            object local_ymax = ymax;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetWorkingArea(ref local_xmin, ref local_ymin, ref local_xmax, ref local_ymax));
            xmin = local_xmin;
            ymin = local_ymin;
            xmax = local_xmax;
            ymax = local_ymax;
            return retVal;
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int ImportDGN(string filename, double scale, double x, double y, int rot, string font, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ImportDGN(filename, scale, x, y, rot, font, flags));
        }

        public int ImportDXF(string filename, double scale, double x, double y, int rot, string font, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ImportDXF(filename, scale, x, y, rot, font, flags));
        }

        public int Is2DView()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Is2DView());
        }

        public int IsClipboardPart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsClipboardPart());
        }

        public int IsEmbedded()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsEmbedded());
        }

        public int IsFormboard()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFormboard());
        }

        public int IsFunctionalDesign()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFunctionalDesign());
        }

        public int IsLocked()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLocked());
        }

        public int IsLockedByAccessControl()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLockedByAccessControl());
        }

        public int IsOffline()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsOffline());
        }

        public int IsPanel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPanel());
        }

        public int IsParentSheet(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsParentSheet(flags));
        }

        public int IsReadOnly()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsReadOnly());
        }

        public int IsReadOnlyInProject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsReadOnlyInProject());
        }

        public int IsShared()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsShared());
        }

        public int IsTerminalPlan()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsTerminalPlan());
        }

        public int IsTopology()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsTopology());
        }

        public int LockObject()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LockObject());
        }

        public int MoveTo(int position, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.MoveTo(position, before));
        }

        public int PlacePart(string name, string version, double x, double y, double rot)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlacePart(name, version, x, y, rot));
        }

        public int PlacePartEx(string name, string version, int flags, double x, double y, double rot)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlacePartEx(name, version, flags, x, y, rot));
        }

        public int PrintOut(double scale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PrintOut(scale));
        }

        public int Remove()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Remove());
        }

        public int Search(int modi, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(modi, name));
        }

        public int SelectIds(ref object symbolIds, out object selectedIds)
        {
            object local_symbolIds = symbolIds;
            object local_selectedIds = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SelectIds(ref local_symbolIds, out local_selectedIds));
            symbolIds = local_symbolIds;
            selectedIds = local_selectedIds;
            return retVal;
        }

        public int Set2DViewSheetDisplayOnlyBorder(int display_border)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Set2DViewSheetDisplayOnlyBorder(display_border));
        }

        public int Set2DViewSheetDisplaySlots(int display_slots)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Set2DViewSheetDisplaySlots(display_slots));
        }

        public int SetAssignment(string newass)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAssignment(newass));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetCharacteristic(string characteristic)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCharacteristic(characteristic));
        }

        public int SetCompleteName(string newnam, string newass, string newloc)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCompleteName(newnam, newass, newloc));
        }

        public int SetCompleteNameEx(string newnam, string newass, string newloc, int onlygiven)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCompleteNameEx(newnam, newass, newloc, onlygiven));
        }

        public int SetContentModified(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetContentModified(value));
        }

        public int SetDisplayModelViewAtPosition(int display_model_view_at_position, double view_distance, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDisplayModelViewAtPosition(display_model_view_at_position, view_distance, flags));
        }

        public int SetFormat(string sym, string rot)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFormat(sym, rot));
        }

        public int SetGetterOptionHandlingMode(int mode)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGetterOptionHandlingMode(mode));
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

        public int SetLocation(string newloc)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLocation(newloc));
        }

        public string SetName(string name)
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

        public int SetPanelRegion(double xoff, double yoff, double scale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPanelRegion(xoff, yoff, scale));
        }

        public int SetProduct(string newproduct)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetProduct(newproduct));
        }

        public int SetReadOnlyInProject(int readonlyproject)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetReadOnlyInProject(readonlyproject));
        }

        public int SetSchematicTypes(ref object types)
        {
            object local_types = types;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetSchematicTypes(ref local_types));
            types = local_types;
            return retVal;
        }

        public int SetSheetRegion(double xoff, double yoff, double scale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSheetRegion(xoff, yoff, scale));
        }

        public int SetTopologyRegion(double xoff, double yoff, double scale)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTopologyRegion(xoff, yoff, scale));
        }

        public int SetVisibleArea(double xmin, double ymin, double xmax, double ymax)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetVisibleArea(xmin, ymin, xmax, ymax));
        }

        public int ShareWithID(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ShareWithID(id));
        }

        public int ToGrid(ref object xpos, ref object ypos)
        {
            object local_xpos = xpos;
            object local_ypos = ypos;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.ToGrid(ref local_xpos, ref local_ypos));
            xpos = local_xpos;
            ypos = local_ypos;
            return retVal;
        }

        public int UnlockObject(string password)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnlockObject(password));
        }

        public int Visible()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Visible());
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

using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3Tree : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Tree _raw;
        private bool _disposed;

        public e3Tree(Zuken.E3.Interop.e3Tree raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Tree RawObject => _raw;

        public int Create(string name, int position, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name, position, before));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetNames(ref object names)
        {
            object local_names = names;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetNames(ref local_names));
            names = local_names;
            return retVal;
        }

        public int GetSelectedAllDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedAllDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedAllDeviceIdsByFolder(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedAllDeviceIdsByFolder(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedBlockIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedBlockIds(ref local_ids));
            ids = local_ids;
            return retVal;
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

        public int GetSelectedCableIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedCableIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedConnectorIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedConnectorIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedDeviceIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedDeviceIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedExternalDocumentIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedExternalDocumentIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedExternalDocumentIdsByFolder(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedExternalDocumentIdsByFolder(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedPinIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedPinIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedSheetIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedSheetIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedSheetIdsByFolder(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedSheetIdsByFolder(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedStructureNodeIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedStructureNodeIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedSymbolIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedSymbolIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSelectedTerminalIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSelectedTerminalIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetSortingMethod(ref object flags, ref object structure, ref object freetab)
        {
            object local_flags = flags;
            object local_structure = structure;
            object local_freetab = freetab;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSortingMethod(ref local_flags, ref local_structure, ref local_freetab));
            flags = local_flags;
            structure = local_structure;
            freetab = local_freetab;
            return retVal;
        }

        public int GetTreeType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTreeType());
        }

        public int GetVisibleInfoTypes(ref object views, ref object schematic)
        {
            object local_views = views;
            object local_schematic = schematic;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetVisibleInfoTypes(ref local_views, ref local_schematic));
            views = local_views;
            schematic = local_schematic;
            return retVal;
        }

        public int GetVisibleInfoTypesEx(ref object views, ref object schematicTypes, ref object formboardSheetIds)
        {
            object local_views = views;
            object local_schematicTypes = schematicTypes;
            object local_formboardSheetIds = formboardSheetIds;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetVisibleInfoTypesEx(ref local_views, ref local_schematicTypes, ref local_formboardSheetIds));
            views = local_views;
            schematicTypes = local_schematicTypes;
            formboardSheetIds = local_formboardSheetIds;
            return retVal;
        }

        public int GetVisibleObjectTypes(ref object type_array)
        {
            object local_type_array = type_array;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetVisibleObjectTypes(ref local_type_array));
            type_array = local_type_array;
            return retVal;
        }

        public int IsActive()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsActive());
        }

        public int IsVisible()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsVisible());
        }

        public int SetIcon(string filename, int index)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetIcon(filename, index));
        }

        public int SetId(int treeid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(treeid));
        }

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
        }

        public int SetNames(ref object names)
        {
            object local_names = names;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetNames(ref local_names));
            names = local_names;
            return retVal;
        }

        public int SetSortingMethod(int flags, ref object structure, ref object freetab)
        {
            object local_structure = structure;
            object local_freetab = freetab;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetSortingMethod(flags, ref local_structure, ref local_freetab));
            structure = local_structure;
            freetab = local_freetab;
            return retVal;
        }

        public int SetVisibleInfoTypes(string views, string schematic)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetVisibleInfoTypes(views, schematic));
        }

        public int SetVisibleInfoTypesEx(ref object views, ref object schematicTypes, ref object formboardSheetIds)
        {
            object local_views = views;
            object local_schematicTypes = schematicTypes;
            object local_formboardSheetIds = formboardSheetIds;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetVisibleInfoTypesEx(ref local_views, ref local_schematicTypes, ref local_formboardSheetIds));
            views = local_views;
            schematicTypes = local_schematicTypes;
            formboardSheetIds = local_formboardSheetIds;
            return retVal;
        }

        public int SetVisibleObjectTypes(ref object type_array)
        {
            object local_type_array = type_array;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetVisibleObjectTypes(ref local_type_array));
            type_array = local_type_array;
            return retVal;
        }

        public int ViewSignalTree(int bShowTree)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ViewSignalTree(bShowTree));
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

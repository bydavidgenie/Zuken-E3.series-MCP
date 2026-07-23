using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Group : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Group _raw;
        private bool _disposed;

        public e3Group(Zuken.E3.Interop.e3Group raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Group RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int AddItems(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.AddItems(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int Create(ref object ids, string name)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Create(ref local_ids, name));
            ids = local_ids;
            return retVal;
        }

        public int Delete(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Delete(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int DeleteAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteAttribute(name));
        }

        public int DeleteContents()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteContents());
        }

        public int DeleteUnplaced()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteUnplaced());
        }

        public int GetAnyIds(uint flags, out object anyids)
        {
            object local_anyids = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAnyIds(flags, out local_anyids));
            anyids = local_anyids;
            return retVal;
        }

        public int GetAttributeIds(ref object ids, string name)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeIds(ref local_ids, name));
            ids = local_ids;
            return retVal;
        }

        public string GetAttributeValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetAttributeValue(name));
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetGroupId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGroupId(id));
        }

        public int GetGroupType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGroupType());
        }

        public string GetGUID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGUID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetItems(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetItems(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetLocation(ref object x, ref object y, ref object z, ref object grid, ref object column_value, ref object row_value)
        {
            object local_x = x;
            object local_y = y;
            object local_z = z;
            object local_grid = grid;
            object local_column_value = column_value;
            object local_row_value = row_value;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetLocation(ref local_x, ref local_y, ref local_z, ref local_grid, ref local_column_value, ref local_row_value));
            x = local_x;
            y = local_y;
            z = local_z;
            grid = local_grid;
            column_value = local_column_value;
            row_value = local_row_value;
            return retVal;
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public string GetPartName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPartName());
        }

        public int IsPart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPart());
        }

        public int IsSubCircuit()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsSubCircuit());
        }

        public int IsUnplaced()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsUnplaced());
        }

        public int Place(int shtId, double x, double y, double z, double rotation)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Place(shtId, x, y, z, rotation));
        }

        public int PlaceInteractively()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PlaceInteractively());
        }

        public int RemoveItems(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.RemoveItems(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
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

        public int SetName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(name));
        }

        public int SetPartName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPartName(name));
        }

        public int Unplace()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Unplace());
        }

        public int UpdateDrawingForProjectGeneration(uint flags, ref object substitutes, ref object allowedTexttypes, ref object allowedAttributenames, ref object resultArray)
        {
            object local_substitutes = substitutes;
            object local_allowedTexttypes = allowedTexttypes;
            object local_allowedAttributenames = allowedAttributenames;
            object local_resultArray = resultArray;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.UpdateDrawingForProjectGeneration(flags, ref local_substitutes, ref local_allowedTexttypes, ref local_allowedAttributenames, ref local_resultArray));
            substitutes = local_substitutes;
            allowedTexttypes = local_allowedTexttypes;
            allowedAttributenames = local_allowedAttributenames;
            resultArray = local_resultArray;
            return retVal;
        }

        public int UpdatePart()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdatePart());
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

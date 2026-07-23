using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3ExternalDocument : IDisposable
    {
        private readonly Zuken.E3.Interop.e3ExternalDocument _raw;
        private bool _disposed;

        public e3ExternalDocument(Zuken.E3.Interop.e3ExternalDocument raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3ExternalDocument RawObject => _raw;

        public int AddAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AddAttributeValue(name, value));
        }

        public int checkin(int unlock)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.checkin(unlock));
        }

        public int CheckOut(int @lock)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CheckOut(@lock));
        }

        public int Create(int modi, string name, string file)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(modi, name, file));
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

        public string GetFile()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFile());
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

        public string GetInternalName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInternalName());
        }

        public string GetLocation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLocation());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public string GetOwner()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetOwner());
        }

        public int HasAttribute(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasAttribute(name));
        }

        public int InsertFile(int modi, string name, string file)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.InsertFile(modi, name, file));
        }

        public int IsOffline()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsOffline());
        }

        public int IsReadOnly()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsReadOnly());
        }

        public int IsVisible()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsVisible());
        }

        public int MoveTo(int position, int before)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.MoveTo(position, before));
        }

        public int Remove()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Remove());
        }

        public int Save()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Save());
        }

        public int Search(int modi, string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(modi, name));
        }

        public int SetAssignment(string newass)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAssignment(newass));
        }

        public int SetAttributeValue(string name, string value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetAttributeValue(name, value));
        }

        public int SetCompleteName(string newnam, string newass, string newloc)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCompleteName(newnam, newass, newloc));
        }

        public int SetCompleteNameEx(string newnam, string newass, string newloc, int onlygiven)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCompleteNameEx(newnam, newass, newloc, onlygiven));
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

        public string SetName(string newname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetName(newname));
        }

        public int SetVisible(int Visible)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetVisible(Visible));
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

using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3Variant : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Variant _raw;
        private bool _disposed;

        public e3Variant(Zuken.E3.Interop.e3Variant raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Variant RawObject => _raw;

        public int Create(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name));
        }

        public int Delete(int del)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete(del));
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

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int IsActive()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsActive());
        }

        public int Search(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Search(name));
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

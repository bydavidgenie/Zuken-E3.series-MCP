using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3EmbeddedObject : IDisposable
    {
        private readonly Zuken.E3.Interop.e3EmbeddedObject _raw;
        private bool _disposed;

        public e3EmbeddedObject(Zuken.E3.Interop.e3EmbeddedObject raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3EmbeddedObject RawObject => _raw;

        public int Create(string filename, int shti, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(filename, shti, x, y));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public string GetGID()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetGID());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int Move(int shti, double x, double y)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Move(shti, x, y));
        }

        public int Open()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Open());
        }

        public int Resize(double width, double height)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Resize(width, height));
        }

        public string SetGID(string gid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetGID(gid));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
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

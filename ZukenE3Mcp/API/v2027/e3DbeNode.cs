using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3DbeNode : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeNode _raw;
        private bool _disposed;

        public e3DbeNode(Zuken.E3.Interop.e3DbeNode raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeNode RawObject => _raw;

        public int GetDirection(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDirection(flags));
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetPosition(ref object x, ref object y)
        {
            object local_x = x;
            object local_y = y;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPosition(ref local_x, ref local_y));
            x = local_x;
            y = local_y;
            return retVal;
        }

        public int GetTextIds(ref object ids, int texttype)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTextIds(ref local_ids, texttype));
            ids = local_ids;
            return retVal;
        }

        public int HasPassWires()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.HasPassWires());
        }

        public int IsBusbarPin()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBusbarPin());
        }

        public int IsBusPin()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBusPin());
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

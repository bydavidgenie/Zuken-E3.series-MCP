using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2027
{
    public class e3DbeJob : IDisposable
    {
        private readonly Zuken.E3.Interop.e3DbeJob _raw;
        private bool _disposed;

        public e3DbeJob(Zuken.E3.Interop.e3DbeJob raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3DbeJob RawObject => _raw;

        public int Close(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Close(flags));
        }

        public int Create(string name, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(name, flags));
        }

        public e3DbeAttribute CreateDbeAttributeObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDbeAttributeObject());
            return rawResult != null ? new e3DbeAttribute((Zuken.E3.Interop.e3DbeAttribute)rawResult) : null;
        }

        public e3DbeComponent CreateDbeComponentObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDbeComponentObject());
            return rawResult != null ? new e3DbeComponent((Zuken.E3.Interop.e3DbeComponent)rawResult) : null;
        }

        public e3DbeGraph CreateDbeGraphObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDbeGraphObject());
            return rawResult != null ? new e3DbeGraph((Zuken.E3.Interop.e3DbeGraph)rawResult) : null;
        }

        public e3DbeModel CreateDbeModelObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDbeModelObject());
            return rawResult != null ? new e3DbeModel((Zuken.E3.Interop.e3DbeModel)rawResult) : null;
        }

        public e3DbeModelPin CreateDbeModelPinObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDbeModelPinObject());
            return rawResult != null ? new e3DbeModelPin((Zuken.E3.Interop.e3DbeModelPin)rawResult) : null;
        }

        public e3DbeNode CreateDbeNodeObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDbeNodeObject());
            return rawResult != null ? new e3DbeNode((Zuken.E3.Interop.e3DbeNode)rawResult) : null;
        }

        public e3DbeSlot CreateDbeSlotObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDbeSlotObject());
            return rawResult != null ? new e3DbeSlot((Zuken.E3.Interop.e3DbeSlot)rawResult) : null;
        }

        public e3DbeSymbol CreateDbeSymbolObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDbeSymbolObject());
            return rawResult != null ? new e3DbeSymbol((Zuken.E3.Interop.e3DbeSymbol)rawResult) : null;
        }

        public e3DbeText CreateDbeTextObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDbeTextObject());
            return rawResult != null ? new e3DbeText((Zuken.E3.Interop.e3DbeText)rawResult) : null;
        }

        public int DeleteComponent(string name, string version, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteComponent(name, version, flags));
        }

        public int DeleteModel(string name, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteModel(name, flags));
        }

        public int DeleteSymbol(string name, string version, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteSymbol(name, version, flags));
        }

        public int EditComponent(string name, string version, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.EditComponent(name, version, flags));
        }

        public int EditModel(string name, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.EditModel(name, flags));
        }

        public int EditSymbol(string name, string version, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.EditSymbol(name, version, flags));
        }

        public int GetActiveComponentId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetActiveComponentId());
        }

        public int GetActiveModelId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetActiveModelId());
        }

        public int GetActiveSymbolId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetActiveSymbolId());
        }

        public int GetComponentIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetComponentIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetModelIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetModelIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public int GetOutbarText(int index, ref object lst)
        {
            object local_lst = lst;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOutbarText(index, ref local_lst));
            lst = local_lst;
            return retVal;
        }

        public int GetOutbarTextEx(int index, ref object lst)
        {
            object local_lst = lst;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetOutbarTextEx(index, ref local_lst));
            lst = local_lst;
            return retVal;
        }

        public string GetPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPath());
        }

        public int GetResultText(int index, ref object lst)
        {
            object local_lst = lst;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetResultText(index, ref local_lst));
            lst = local_lst;
            return retVal;
        }

        public int GetResultTextEx(int index, ref object lst)
        {
            object local_lst = lst;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetResultTextEx(index, ref local_lst));
            lst = local_lst;
            return retVal;
        }

        public object GetSettingValue(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSettingValue(name));
        }

        public int GetSymbolIds(ref object ids, int flags)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolIds(ref local_ids, flags));
            ids = local_ids;
            return retVal;
        }

        public string GetType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetType());
        }

        public int New(string name, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.New(name, flags));
        }

        public int NewComponent(string name, string version, string baseName, string baseVersion, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.NewComponent(name, version, baseName, baseVersion, flags));
        }

        public int NewModel(string name, string baseName, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.NewModel(name, baseName, flags));
        }

        public int NewSymbol(string name, string version, string baseName, string baseVersion, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.NewSymbol(name, version, baseName, baseVersion, flags));
        }

        public int Open(string name, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Open(name, flags));
        }

        public int Save(int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Save(flags));
        }

        public int SaveAs(string name, int compressed, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveAs(name, compressed, flags));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public object SetSettingValue(string name, ref object value)
        {
            object local_value = value;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetSettingValue(name, ref local_value));
            value = local_value;
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

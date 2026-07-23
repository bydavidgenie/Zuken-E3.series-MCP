using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2026
{
    public class e3UserMenuItem : IDisposable
    {
        private readonly Zuken.E3.Interop.e3UserMenuItem _raw;
        private bool _disposed;

        public e3UserMenuItem(Zuken.E3.Interop.e3UserMenuItem raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3UserMenuItem RawObject => _raw;

        public int Create(int id, string text, string command, string parameters, string folder, string image, string shortcut, int Visible, int wait, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Create(id, text, command, parameters, folder, image, shortcut, Visible, wait, flags));
        }

        public int CreateContextSeparator(string text)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateContextSeparator(text));
        }

        public int CreateContextUserTool(string text, string command)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateContextUserTool(text, command));
        }

        public int CreateSeparator(string text)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateSeparator(text));
        }

        public int CreateUserTool(string text, string command)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.CreateUserTool(text, command));
        }

        public int Delete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Delete());
        }

        public int DeleteContext()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteContext());
        }

        public int DeleteUserTool()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteUserTool());
        }

        public string GetCommand()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCommand());
        }

        public string GetDescription()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetDescription());
        }

        public int GetEnable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetEnable());
        }

        public string GetFolder()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFolder());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public string GetImage()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetImage());
        }

        public string GetParameters()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetParameters());
        }

        public string GetShortCut()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetShortCut());
        }

        public string GetText()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetText());
        }

        public int GetType()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetType());
        }

        public int GetVisible()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVisible());
        }

        public int GetWaitForEndOfCommand()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetWaitForEndOfCommand());
        }

        public int IsDeleted()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsDeleted());
        }

        public int SetCommand(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetCommand(newval));
        }

        public int SetDescription(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDescription(newval));
        }

        public int SetEnable(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetEnable(newval));
        }

        public int SetFolder(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetFolder(newval));
        }

        public int SetId(int id)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetId(id));
        }

        public int SetImage(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetImage(newval));
        }

        public int SetParameters(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetParameters(newval));
        }

        public int SetShortCut(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetShortCut(newval));
        }

        public int SetText(string newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetText(newval));
        }

        public int SetVisible(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetVisible(newval));
        }

        public int SetWaitForEndOfCommand(int newval)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetWaitForEndOfCommand(newval));
        }

        public int UnDelete()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UnDelete());
        }

        public int UpdateUserInterface()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.UpdateUserInterface());
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

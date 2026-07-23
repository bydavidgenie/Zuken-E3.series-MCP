using System;
using System.Runtime.InteropServices;

namespace ZukenE3Mcp.API.v2025
{
    public class e3Application : IDisposable
    {
        private readonly Zuken.E3.Interop.e3Application _raw;
        private bool _disposed;

        public e3Application(Zuken.E3.Interop.e3Application raw)
        {
            _raw = raw;
        }

        public Zuken.E3.Interop.e3Application RawObject => _raw;

        public int ActivateOutputWindow(int windowId)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ActivateOutputWindow(windowId));
        }

        public int AvoidAutomaticClosing(int avoid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.AvoidAutomaticClosing(avoid));
        }

        public int BeginForeignTask()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.BeginForeignTask());
        }

        public int BringToForeground()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.BringToForeground());
        }

        public double CalculateCircumcircleDiameter(ref object dias)
        {
            object local_dias = dias;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CalculateCircumcircleDiameter(ref local_dias));
            dias = local_dias;
            return retVal;
        }

        public void ClearOutputWindow()
        {
            StaThreadExecutor.Instance.Execute(() => _raw.ClearOutputWindow());
        }

        public void ClearResultWindow()
        {
            StaThreadExecutor.Instance.Execute(() => _raw.ClearResultWindow());
        }

        public int CloneWithProject(ref object ppid, string com, string data)
        {
            object local_ppid = ppid;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.CloneWithProject(ref local_ppid, com, data));
            ppid = local_ppid;
            return retVal;
        }

        public e3DllInterface CreateDllObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateDllObject());
            return rawResult != null ? new e3DllInterface((Zuken.E3.Interop.e3DllInterface)rawResult) : null;
        }

        public e3Job CreateJobObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateJobObject());
            return rawResult != null ? new e3Job((Zuken.E3.Interop.e3Job)rawResult) : null;
        }

        public e3UserMenuItem CreateMenuItemObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateMenuItemObject());
            return rawResult != null ? new e3UserMenuItem((Zuken.E3.Interop.e3UserMenuItem)rawResult) : null;
        }

        public e3Wespe CreateWespeObject()
        {
            var rawResult = StaThreadExecutor.Instance.Execute(() => _raw.CreateWespeObject());
            return rawResult != null ? new e3Wespe((Zuken.E3.Interop.e3Wespe)rawResult) : null;
        }

        public int DeleteWorkspaceConfiguration(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.DeleteWorkspaceConfiguration(name));
        }

        public int Display()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Display());
        }

        public int EnableCOM(string password)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.EnableCOM(password));
        }

        public int EnableLogfile(int en)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.EnableLogfile(en));
        }

        public int EndForeignTask()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.EndForeignTask());
        }

        public int FreeLicense(string feature)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FreeLicense(feature));
        }

        public int FreeLicensePermanent(string feature)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.FreeLicensePermanent(feature));
        }

        public string fullname()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.fullname());
        }

        public string GetActualDatabase()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetActualDatabase());
        }

        public int GetAvailableLanguages(ref object languages)
        {
            object local_languages = languages;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetAvailableLanguages(ref local_languages));
            languages = local_languages;
            return retVal;
        }

        public string GetBuild()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetBuild());
        }

        public object GetCloningInformation(string what)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCloningInformation(what));
        }

        public string GetComponentDatabase()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentDatabase());
        }

        public string GetComponentDatabaseTableSchema()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentDatabaseTableSchema());
        }

        public string GetComponentDataView()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetComponentDataView());
        }

        public int GetComponentList(ref object result, ref object additionalAttributes, int flags)
        {
            object local_result = result;
            object local_additionalAttributes = additionalAttributes;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetComponentList(ref local_result, ref local_additionalAttributes, flags));
            result = local_result;
            additionalAttributes = local_additionalAttributes;
            return retVal;
        }

        public string GetConfigFile(int processType, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConfigFile(processType, flags));
        }

        public string GetConfigurationDatabase()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConfigurationDatabase());
        }

        public string GetConfigurationDatabaseTableSchema()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetConfigurationDatabaseTableSchema());
        }

        public string GetCurrentWorkspaceConfiguration()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetCurrentWorkspaceConfiguration());
        }

        public int GetDatabaseTableSelectedComponents(ref object ComponentArray, ref object VersionArray)
        {
            object local_ComponentArray = ComponentArray;
            object local_VersionArray = VersionArray;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDatabaseTableSelectedComponents(ref local_ComponentArray, ref local_VersionArray));
            ComponentArray = local_ComponentArray;
            VersionArray = local_VersionArray;
            return retVal;
        }

        public int GetDatabaseTreeSelectedComponents(out object ComponentArray, out object VersionArray)
        {
            object local_ComponentArray = default;
            object local_VersionArray = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDatabaseTreeSelectedComponents(out local_ComponentArray, out local_VersionArray));
            ComponentArray = local_ComponentArray;
            VersionArray = local_VersionArray;
            return retVal;
        }

        public int GetDatabaseTreeSelectedModels(out object ModelArray)
        {
            object local_ModelArray = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDatabaseTreeSelectedModels(out local_ModelArray));
            ModelArray = local_ModelArray;
            return retVal;
        }

        public int GetDatabaseTreeSelectedSymbols(out object SymbolArray, out object VersionArray)
        {
            object local_SymbolArray = default;
            object local_VersionArray = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDatabaseTreeSelectedSymbols(out local_SymbolArray, out local_VersionArray));
            SymbolArray = local_SymbolArray;
            VersionArray = local_VersionArray;
            return retVal;
        }

        public int GetDefinedDatabaseConnectionStrings(string dbname, out object cmp_cs, out object sym_cs, out object cnf_cs)
        {
            object local_cmp_cs = default;
            object local_sym_cs = default;
            object local_cnf_cs = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDefinedDatabaseConnectionStrings(dbname, out local_cmp_cs, out local_sym_cs, out local_cnf_cs));
            cmp_cs = local_cmp_cs;
            sym_cs = local_sym_cs;
            cnf_cs = local_cnf_cs;
            return retVal;
        }

        public int GetDefinedDatabases(out object dbnames)
        {
            object local_dbnames = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetDefinedDatabases(out local_dbnames));
            dbnames = local_dbnames;
            return retVal;
        }

        public int GetEnableInteractiveDialogs()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetEnableInteractiveDialogs());
        }

        public int GetErrorCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetErrorCount());
        }

        public string GetFullName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetFullName());
        }

        public int GetId()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetId());
        }

        public int GetInfoCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInfoCount());
        }

        public int GetInstallationLanguage()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInstallationLanguage());
        }

        public string GetInstallationPath()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetInstallationPath());
        }

        public int GetJobCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetJobCount());
        }

        public int GetJobIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetJobIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetLanguageDatabase()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLanguageDatabase());
        }

        public string GetLanguageDatabaseTableSchema()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLanguageDatabaseTableSchema());
        }

        public int GetLicense(string feature)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLicense(feature));
        }

        public int GetLicensePermanent(string feature)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLicensePermanent(feature));
        }

        public string GetLogfileName(int index)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetLogfileName(index));
        }

        public object GetModalWindow()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetModalWindow());
        }

        public int GetModelList(ref object result, ref object additionalAttributes, int flags)
        {
            object local_result = result;
            object local_additionalAttributes = additionalAttributes;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetModelList(ref local_result, ref local_additionalAttributes, flags));
            result = local_result;
            additionalAttributes = local_additionalAttributes;
            return retVal;
        }

        public int GetMultiuserFolderPath(out object path)
        {
            object local_path = default;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetMultiuserFolderPath(out local_path));
            path = local_path;
            return retVal;
        }

        public int GetMultiuserProjects(ref object name)
        {
            object local_name = name;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetMultiuserProjects(ref local_name));
            name = local_name;
            return retVal;
        }

        public string GetMultiuserServer()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetMultiuserServer());
        }

        public string GetName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetName());
        }

        public object GetPluginObject(ref object Plugin)
        {
            object local_Plugin = Plugin;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPluginObject(ref local_Plugin));
            Plugin = local_Plugin;
            return retVal;
        }

        public int GetPrintCropMarks()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPrintCropMarks());
        }

        public int GetPrinterColour()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPrinterColour());
        }

        public double GetPrinterLinewidth()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPrinterLinewidth());
        }

        public int GetPrinterMargins(ref object top, ref object bottom, ref object left, ref object right)
        {
            object local_top = top;
            object local_bottom = bottom;
            object local_left = left;
            object local_right = right;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetPrinterMargins(ref local_top, ref local_bottom, ref local_left, ref local_right));
            top = local_top;
            bottom = local_bottom;
            left = local_left;
            right = local_right;
            return retVal;
        }

        public string GetPrinterName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPrinterName());
        }

        public int GetPrintPageNumbers()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPrintPageNumbers());
        }

        public int GetPrintSheetOrder()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPrintSheetOrder());
        }

        public int GetPrintSplitPages()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetPrintSplitPages());
        }

        public object GetProcessProperty(string what)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetProcessProperty(what));
        }

        public int GetProjectInformation(ref object filename, ref object type, ref object is_dbe)
        {
            object local_filename = filename;
            object local_type = type;
            object local_is_dbe = is_dbe;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetProjectInformation(ref local_filename, ref local_type, ref local_is_dbe));
            filename = local_filename;
            type = local_type;
            is_dbe = local_is_dbe;
            return retVal;
        }

        public string GetProjectLifecycle(string project)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetProjectLifecycle(project));
        }

        public string GetProvider(string dbname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetProvider(dbname));
        }

        public string GetRegistryVersion()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetRegistryVersion());
        }

        public object GetScriptArguments()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetScriptArguments());
        }

        public int GetScriptReturn()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetScriptReturn());
        }

        public string GetServerName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetServerName());
        }

        public int GetServerPort()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetServerPort());
        }

        public string GetSymbolDatabase()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolDatabase());
        }

        public string GetSymbolDatabaseTableSchema()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolDatabaseTableSchema());
        }

        public string GetSymbolDataView()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetSymbolDataView());
        }

        public int GetSystemMenuItemIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetSystemMenuItemIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public string GetTemplateFile()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTemplateFile());
        }

        public string GetTemplateFileDBE()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTemplateFileDBE());
        }

        public int GetTestMark(int num)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTestMark(num));
        }

        public string GetTranslatedText(string text, string language)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTranslatedText(text, language));
        }

        public int GetTrigger(string name, ref object filename)
        {
            object local_filename = filename;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetTrigger(name, ref local_filename));
            filename = local_filename;
            return retVal;
        }

        public int GetTriggerReturn()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetTriggerReturn());
        }

        public int GetUserMenuItemIds(ref object ids)
        {
            object local_ids = ids;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetUserMenuItemIds(ref local_ids));
            ids = local_ids;
            return retVal;
        }

        public int GetUseSheetOrientation()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetUseSheetOrientation());
        }

        public int GetVerifyCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVerifyCount());
        }

        public string GetVersion()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetVersion());
        }

        public int GetWarningCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetWarningCount());
        }

        public int GetWorkspaceConfigurations(ref object names, string path)
        {
            object local_names = names;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.GetWorkspaceConfigurations(ref local_names, path));
            names = local_names;
            return retVal;
        }

        public string GetWorkspaceName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.GetWorkspaceName());
        }

        public int Include(string text)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Include(text));
        }

        public int IsBasic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBasic());
        }

        public int IsBoard()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsBoard());
        }

        public int IsCable()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCable());
        }

        public int IsCaddy()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCaddy());
        }

        public int IsCaddyBasic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCaddyBasic());
        }

        public int IsCaddyDemo()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCaddyDemo());
        }

        public int IsCaddyEconomy()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsCaddyEconomy());
        }

        public int IsDemo()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsDemo());
        }

        public int IsDistDesign()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsDistDesign());
        }

        public int IsEconomy()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsEconomy());
        }

        public int IsFluid()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFluid());
        }

        public int IsFormboard()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFormboard());
        }

        public int IsFunctionalDesign()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsFunctionalDesign());
        }

        public int IsLogic()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsLogic());
        }

        public int IsMultiuser()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsMultiuser());
        }

        public int IsPanel()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsPanel());
        }

        public int IsRedliner()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsRedliner());
        }

        public int IsSchema()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsSchema());
        }

        public int IsScriptRunning()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsScriptRunning());
        }

        public int IsSmallBusiness()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsSmallBusiness());
        }

        public int IsStudent()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsStudent());
        }

        public int IsViewer()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsViewer());
        }

        public int IsViewPlus()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsViewPlus());
        }

        public int IsWago()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsWago());
        }

        public int IsWagoDemo()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsWagoDemo());
        }

        public int IsWire()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsWire());
        }

        public int IsWireWorks()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.IsWireWorks());
        }

        public int LoadWorkspaceConfigurationFromFile(string name, string path)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.LoadWorkspaceConfigurationFromFile(name, path));
        }

        public int Maximize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Maximize());
        }

        public int Minimize()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Minimize());
        }

        public int PutError(int ok, string text, int item)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutError(ok, text, item));
        }

        public int PutErrorEx(int flags, string text, int item, int red, int green, int blue)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutErrorEx(flags, text, item, red, green, blue));
        }

        public int PutInfo(int ok, string text, int item)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutInfo(ok, text, item));
        }

        public int PutInfoEx(int flags, string text, int item, int red, int green, int blue)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutInfoEx(flags, text, item, red, green, blue));
        }

        public int PutMessage(string text, int item)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutMessage(text, item));
        }

        public int PutMessageEx(int flags, string text, int item, int red, int green, int blue)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutMessageEx(flags, text, item, red, green, blue));
        }

        public int PutMultiuserLogMessage(string source, string text)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutMultiuserLogMessage(source, text));
        }

        public int PutVerify(int ok, string text, int item)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutVerify(ok, text, item));
        }

        public int PutVerifyEx(int flags, string text, int item, int red, int green, int blue)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutVerifyEx(flags, text, item, red, green, blue));
        }

        public int PutWarning(int ok, string text, int item)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutWarning(ok, text, item));
        }

        public int PutWarningEx(int flags, string text, int item, int red, int green, int blue)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.PutWarningEx(flags, text, item, red, green, blue));
        }

        public int Quit()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Quit());
        }

        public int ResetErrorCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetErrorCount());
        }

        public int ResetInfoCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetInfoCount());
        }

        public int ResetVerifyCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetVerifyCount());
        }

        public int ResetWarningCount()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ResetWarningCount());
        }

        public int RestoreWorkspaceConfiguration(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.RestoreWorkspaceConfiguration(name));
        }

        public int Run(string filename, ref object arguments)
        {
            object local_arguments = arguments;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.Run(filename, ref local_arguments));
            arguments = local_arguments;
            return retVal;
        }

        public int SaveWorkspaceConfiguration(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SaveWorkspaceConfiguration(name));
        }

        public object ScriptArguments()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ScriptArguments());
        }

        public string ScriptFullName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ScriptFullName());
        }

        public string ScriptName()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ScriptName());
        }

        public int SelectComponentFromTable(ref object ComponentName, ref object ComponentVersion)
        {
            object local_ComponentName = ComponentName;
            object local_ComponentVersion = ComponentVersion;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SelectComponentFromTable(ref local_ComponentName, ref local_ComponentVersion));
            ComponentName = local_ComponentName;
            ComponentVersion = local_ComponentVersion;
            return retVal;
        }

        public int SetActualDatabase(string dbname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetActualDatabase(dbname));
        }

        public int SetChildWindowState(int state)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetChildWindowState(state));
        }

        public int SetComponentDataView(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetComponentDataView(name));
        }

        public string SetConfigFile(int processType, string filepath, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetConfigFile(processType, filepath, flags));
        }

        public int SetDefinedDatabaseConnectionStrings(string dbname, string cmp_cs, string sym_cs, string cnf_cs)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetDefinedDatabaseConnectionStrings(dbname, cmp_cs, sym_cs, cnf_cs));
        }

        public int SetEnableInteractiveDialogs(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetEnableInteractiveDialogs(value));
        }

        public int SetLanguageDatabase(string dbname)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLanguageDatabase(dbname));
        }

        public int SetLogfileName(string logfile, int index)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetLogfileName(logfile, index));
        }

        public int SetModalWindow(ref object hWnd)
        {
            object local_hWnd = hWnd;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SetModalWindow(ref local_hWnd));
            hWnd = local_hWnd;
            return retVal;
        }

        public int SetMultiuserServer(string server)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetMultiuserServer(server));
        }

        public int SetPrintCropMarks(int set)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrintCropMarks(set));
        }

        public int SetPrinterCollate(int col)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrinterCollate(col));
        }

        public int SetPrinterColour(int colour)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrinterColour(colour));
        }

        public int SetPrinterCopies(int copies)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrinterCopies(copies));
        }

        public double SetPrinterLinewidth(double linewidth)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrinterLinewidth(linewidth));
        }

        public int SetPrinterMargins(double top, double bottom, double left, double right)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrinterMargins(top, bottom, left, right));
        }

        public int SetPrinterName(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrinterName(name));
        }

        public int SetPrintPageNumbers(int set)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrintPageNumbers(set));
        }

        public int SetPrintSheetOrder(int set)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrintSheetOrder(set));
        }

        public int SetPrintSplitPages(int set)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetPrintSplitPages(set));
        }

        public int SetProjectLifecycle(string project, string lifecycle)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetProjectLifecycle(project, lifecycle));
        }

        public int SetScriptReturn(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetScriptReturn(value));
        }

        public int SetSymbolDataView(string name)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetSymbolDataView(name));
        }

        public int SetTemplateFile(string templatefilename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTemplateFile(templatefilename));
        }

        public int SetTemplateFileDBE(string templatefilename)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTemplateFileDBE(templatefilename));
        }

        public int SetTestMark(int num, int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTestMark(num, value));
        }

        public int SetTrigger(string name, string filename, int active)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTrigger(name, filename, active));
        }

        public int SetTriggerReturn(int value)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetTriggerReturn(value));
        }

        public int SetUseSheetOrientation(int set)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SetUseSheetOrientation(set));
        }

        public int ShowNormal()
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ShowNormal());
        }

        public int ShowPluginWindow(int bShowPluginWindow, string guid)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ShowPluginWindow(bShowPluginWindow, guid));
        }

        public int ShowWindow(int windowId, int show)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.ShowWindow(windowId, show));
        }

        public int Sleep(int msec)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.Sleep(msec));
        }

        public int SortArrayByIndex(ref object array, int rows, int columns, int sortindex1, int sortindex2)
        {
            object local_array = array;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SortArrayByIndex(ref local_array, rows, columns, sortindex1, sortindex2));
            array = local_array;
            return retVal;
        }

        public int SortArrayByIndexEx(ref object array, ref object options)
        {
            object local_array = array;
            object local_options = options;
            var retVal = StaThreadExecutor.Instance.Execute(() => _raw.SortArrayByIndexEx(ref local_array, ref local_options));
            array = local_array;
            options = local_options;
            return retVal;
        }

        public int SuppressMessages(int suppress, int flags)
        {
            return StaThreadExecutor.Instance.Execute(() => _raw.SuppressMessages(suppress, flags));
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

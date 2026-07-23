using System;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using ZukenE3Mcp.API;
#if E3_2025
using ZukenE3Mcp.API.v2025;
#elif E3_2026
using ZukenE3Mcp.API.v2026;
#else
using ZukenE3Mcp.API.v2027;
#endif

namespace ZukenE3Mcp.Services
{
    public class ScriptEngineService
    {
        public string RunScript(string scriptCode)
        {
            string result = "";
            var thread = new System.Threading.Thread(() =>
            {
                try
                {
                    using var e3App = E3ComConnector.GetE3Application();
                    if (e3App == null)
                    {
                        result = "Error: Zuken E3.series is not running.";
                        return;
                    }

                    using var job = e3App.CreateJobObject();

                    var globals = new ScriptGlobals
                    {
                        App = e3App,
                        Job = job
                    };

                    var options = ScriptOptions.Default
                        .WithReferences(
                            typeof(object).Assembly,                          // System.Private.CoreLib / mscorlib
                            typeof(System.Linq.Enumerable).Assembly,           // System.Linq
                            typeof(System.Collections.Generic.List<>).Assembly, // System.Collections
                            typeof(e3Application).Assembly,                    // ZukenE3Mcp wrappers
                            typeof(Zuken.E3.Interop.e3Application).Assembly    // Raw Interop COM DLL
                        )
                        .WithImports(
                            "System",
                            "System.Collections.Generic",
                            "System.Linq",
                            "System.Text",
                            "ZukenE3Mcp.API"
#if E3_2025
                            , "ZukenE3Mcp.API.v2025"
#elif E3_2026
                            , "ZukenE3Mcp.API.v2026"
#else
                            , "ZukenE3Mcp.API.v2027"
#endif
                        );

                    var script = CSharpScript.Create(
                        scriptCode, 
                        options, 
                        globalsType: typeof(ScriptGlobals)
                    );
                    
                    script.RunAsync(globals).GetAwaiter().GetResult();
                    
                    var outputText = globals.Output.ToString();
                    result = string.IsNullOrEmpty(outputText) ? "Script executed successfully with no log output." : outputText;
                }
                catch (CompilationErrorException compileEx)
                {
                    result = "Compilation Error:\n" + string.Join("\n", compileEx.Diagnostics);
                }
                catch (Exception ex)
                {
                    result = "Execution Error: " + ex.Message + "\n" + ex.StackTrace;
                }
            });

            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            thread.Join(); // Blocks calling thread until STA script execution completes
            return result;
        }
    }
}

using System.Text;
#if E3_2025
using ZukenE3Mcp.API.v2025;
#elif E3_2026
using ZukenE3Mcp.API.v2026;
#else
using ZukenE3Mcp.API.v2027;
#endif

namespace ZukenE3Mcp.Services
{
    public class ScriptGlobals
    {
        public e3Application App { get; set; }
        public e3Job Job { get; set; }
        public StringBuilder Output { get; } = new();

        public void Log(object obj)
        {
            Output.AppendLine(obj?.ToString() ?? "");
        }
    }
}

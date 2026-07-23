using System;
using System.Threading.Tasks;
using ZukenE3Mcp.Protocol;

namespace ZukenE3Mcp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Do NOT redirect standard error to standard output, as it pollutes the JSON-RPC stream.
            // Stderr is captured separately as logs by the parent process.
            var server = new McpServer();
            await server.StartAsync();
        }
    }
}

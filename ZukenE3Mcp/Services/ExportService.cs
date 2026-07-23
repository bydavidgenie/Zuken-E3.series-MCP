using System;
using System.IO;
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
    public class ExportService
    {
        public bool ExportSheetImage(int sheetId, string filename)
        {
            using var e3App = E3ComConnector.GetE3Application();
            if (e3App == null) return false;

            using var job = e3App.CreateJobObject();
            using var sheetObj = job.CreateSheetObject();
            sheetObj.SetId(sheetId);
            if (sheetObj.GetId() == 0) return false;

            string ext = Path.GetExtension(filename).TrimStart('.').ToUpper();
            if (string.IsNullOrEmpty(ext)) ext = "PNG";

            // export parameters: format, version (0), output path, resolution (300 dpi), compression (0)
            return sheetObj.ExportImage(ext, 0, filename, 300, 0) == 1;
        }
    }
}

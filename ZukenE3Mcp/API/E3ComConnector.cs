using System;
using System.Runtime.InteropServices;

#if E3_2025
using ZukenE3Mcp.API.v2025;
#elif E3_2026
using ZukenE3Mcp.API.v2026;
#else
using ZukenE3Mcp.API.v2027;
#endif

namespace ZukenE3Mcp.API
{
    public class E3ComConnector
    {
        [DllImport("oleaut32.dll")]
        private static extern int GetActiveObject([In] ref Guid rclsid, IntPtr pvReserved, [Out] out IntPtr ppunk);

        /// <summary>
        /// Retrieves the active Zuken E3.series Application COM object from the Running Object Table (ROT).
        /// </summary>
        public static e3Application? GetE3Application()
        {
            try
            {
                Type? type = Type.GetTypeFromProgID("CT.Application");
                if (type == null)
                {
                    Console.Error.WriteLine("Error: Zuken E3.series COM class (CT.Application) not registered.");
                    return null;
                }

                Guid clsid = type.GUID;
                int hr = GetActiveObject(ref clsid, IntPtr.Zero, out IntPtr ppunk);
                if (hr != 0)
                {
                    Console.Error.WriteLine($"Error: GetActiveObject for CT.Application returned HRESULT 0x{hr:X8}");
                }
                
                if (hr == 0 && ppunk != IntPtr.Zero)
                {
                    try
                    {
                        var rawObj = Marshal.GetObjectForIUnknown(ppunk);
                        var rawApp = (Zuken.E3.Interop.e3Application)rawObj;
                        return new e3Application(rawApp);
                    }
                    finally
                    {
                        Marshal.Release(ppunk);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error connecting to E3.series COM object: {ex.Message}");
            }
            return null;
        }
    }
}

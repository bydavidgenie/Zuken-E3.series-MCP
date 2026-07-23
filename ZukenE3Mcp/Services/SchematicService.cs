using System;
using System.Collections.Generic;
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
    public class SchematicService
    {
        public class SheetInfo
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }

        public class DeviceSearchResult
        {
            public int id { get; set; }
            public string name { get; set; } = string.Empty;
            public string component_name { get; set; } = string.Empty;
            public string location { get; set; } = string.Empty;
            public string assignment { get; set; } = string.Empty;
            public bool is_cable { get; set; }
            public bool is_connector { get; set; }
            public bool is_terminal { get; set; }
        }

        public class PinDetails
        {
            public int id { get; set; }
            public string name { get; set; } = string.Empty;
            public string signal { get; set; } = string.Empty;
            public int gender { get; set; }
            public bool is_supply { get; set; }
        }

        public class AttributeDetails
        {
            public int id { get; set; }
            public string name { get; set; } = string.Empty;
            public string value { get; set; } = string.Empty;
        }

        public class DeviceDetailsResult
        {
            public int id { get; set; }
            public string name { get; set; } = string.Empty;
            public string component_name { get; set; } = string.Empty;
            public string component_version { get; set; } = string.Empty;
            public string location { get; set; } = string.Empty;
            public string assignment { get; set; } = string.Empty;
            public bool is_assembly { get; set; }
            public bool is_cable { get; set; }
            public bool is_connector { get; set; }
            public List<PinDetails> pins { get; set; } = new();
            public List<AttributeDetails> attributes { get; set; } = new();
        }

        public List<SheetInfo> ListSheets()
        {
            var sheets = new List<SheetInfo>();
            using var e3App = E3ComConnector.GetE3Application();
            if (e3App == null) return sheets;

            using var job = e3App.CreateJobObject();
            if (job.GetId() == 0) return sheets;

            using var sheet = job.CreateSheetObject();
            object sheetIdsObj = null;
            job.GetSheetIds(ref sheetIdsObj);

            if (sheetIdsObj is Array arr)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr.GetValue(i) is int sheetId && sheetId > 0)
                    {
                        sheet.SetId(sheetId);
                        sheets.Add(new SheetInfo
                        {
                            Id = sheetId,
                            Name = sheet.GetName()
                        });
                    }
                }
            }

            return sheets;
        }

        public List<DeviceSearchResult> SearchDevices(string query)
        {
            var results = new List<DeviceSearchResult>();
            using var e3App = E3ComConnector.GetE3Application();
            if (e3App == null) return results;

            using var job = e3App.CreateJobObject();
            if (job.GetId() == 0) return results;

            using var devObj = job.CreateDeviceObject();
            var seenIds = new HashSet<int>();

            object devIdsObj = null;
            job.GetDeviceIds(ref devIdsObj);
            ProcessDeviceIds(devIdsObj, query, devObj, seenIds, results);

            object connIdsObj = null;
            job.GetConnectorIds(ref connIdsObj);
            ProcessDeviceIds(connIdsObj, query, devObj, seenIds, results);

            object cableIdsObj = null;
            job.GetCableIds(ref cableIdsObj);
            ProcessDeviceIds(cableIdsObj, query, devObj, seenIds, results);

            return results;
        }

        private void ProcessDeviceIds(object idsObj, string query, e3Device devObj, HashSet<int> seenIds, List<DeviceSearchResult> results)
        {
            if (idsObj is Array arr)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr.GetValue(i) is int devId && devId > 0 && seenIds.Add(devId))
                    {
                        devObj.SetId(devId);
                        string name = devObj.GetName();
                        string comp = devObj.GetComponentName();
                        string loc = devObj.GetLocation();
                        string ass = devObj.GetAssignment();

                        bool match = string.IsNullOrEmpty(query) ||
                                     name.ToLower().Contains(query) ||
                                     comp.ToLower().Contains(query) ||
                                     loc.ToLower().Contains(query) ||
                                     ass.ToLower().Contains(query);

                        if (match)
                        {
                            results.Add(new DeviceSearchResult
                            {
                                id = devId,
                                name = name,
                                component_name = comp,
                                location = loc,
                                assignment = ass,
                                is_cable = devObj.IsCable() != 0,
                                is_connector = devObj.IsConnector() != 0,
                                is_terminal = devObj.IsTerminal() != 0
                            });
                        }
                    }
                }
            }
        }

        public DeviceDetailsResult? GetDeviceDetails(int deviceId)
        {
            using var e3App = E3ComConnector.GetE3Application();
            if (e3App == null) return null;

            using var job = e3App.CreateJobObject();
            using var devObj = job.CreateDeviceObject();
            devObj.SetId(deviceId);
            if (devObj.GetId() == 0) return null;

            var pins = new List<PinDetails>();
            object pinIdsObj = null;
            devObj.GetPinIds(ref pinIdsObj);
            if (pinIdsObj is Array pinArr)
            {
                using var pinObj = job.CreatePinObject();
                for (int i = 1; i < pinArr.Length; i++)
                {
                    if (pinArr.GetValue(i) is int pId && pId > 0)
                    {
                        pinObj.SetId(pId);
                        pins.Add(new PinDetails
                        {
                            id = pId,
                            name = pinObj.GetName(),
                            signal = pinObj.GetSignalName(),
                            gender = pinObj.GetPinGender(),
                            is_supply = pinObj.IsSupply() != 0
                        });
                    }
                }
            }

            var attributes = new List<AttributeDetails>();
            object attrIdsObj = null;
            devObj.GetAttributeIds(ref attrIdsObj, "");
            if (attrIdsObj is Array attrArr)
            {
                using var attrObj = job.CreateAttributeObject();
                for (int i = 1; i < attrArr.Length; i++)
                {
                    if (attrArr.GetValue(i) is int aId && aId > 0)
                    {
                        attrObj.SetId(aId);
                        attributes.Add(new AttributeDetails
                        {
                            id = aId,
                            name = attrObj.GetName(),
                            value = attrObj.GetValue()
                        });
                    }
                }
            }

            return new DeviceDetailsResult
            {
                id = deviceId,
                name = devObj.GetName(),
                component_name = devObj.GetComponentName(),
                component_version = devObj.GetComponentVersion(),
                location = devObj.GetLocation(),
                assignment = devObj.GetAssignment(),
                is_assembly = devObj.IsAssembly() != 0,
                is_cable = devObj.IsCable() != 0,
                is_connector = devObj.IsConnector() != 0,
                pins = pins,
                attributes = attributes
            };
        }

        public bool RenameDevice(int deviceId, string newName, out string oldName, out string errorMessage)
        {
            oldName = string.Empty;
            errorMessage = string.Empty;

            using var e3App = E3ComConnector.GetE3Application();
            if (e3App == null)
            {
                errorMessage = "E3 is not running.";
                return false;
            }

            using var job = e3App.CreateJobObject();
            using var devObj = job.CreateDeviceObject();
            devObj.SetId(deviceId);
            if (devObj.GetId() == 0)
            {
                errorMessage = $"Device ID {deviceId} not found.";
                return false;
            }

            oldName = devObj.GetName();
            if (devObj.SetName(newName) == 1)
            {
                return true;
            }

            errorMessage = "E3 denied rename request. Ensure the tag is not duplicated and drawing is editable.";
            return false;
        }
    }
}

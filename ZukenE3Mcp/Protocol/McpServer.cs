using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using ZukenE3Mcp.Services;
using ZukenE3Mcp.Tools;

namespace ZukenE3Mcp.Protocol
{
    public class McpServer
    {
        private readonly List<McpTool> _tools = new();
        private readonly Dictionary<string, Func<JsonElement?, Task<McpToolCallResult>>> _toolHandlers = new();

        private readonly ProjectService _projectService = new();
        private readonly SchematicService _schematicService = new();
        private readonly ExportService _exportService = new();
        private readonly ScriptEngineService _scriptService = new();

        public McpServer()
        {
            RegisterTools();
        }

        private void RegisterTools()
        {
            // 1. get_project_status
            RegisterTool(new McpTool
            {
                Name = "get_project_status",
                Description = "Retrieves the name, path, and stats of the currently active Zuken E3.series project.",
                InputSchema = new McpInputSchema { Type = "object" }
            }, GetProjectStatusHandler);

            // 2. list_sheets
            RegisterTool(new McpTool
            {
                Name = "list_sheets",
                Description = "Lists all sheets (drawings) in the active project.",
                InputSchema = new McpInputSchema { Type = "object" }
            }, ListSheetsHandler);

            // 3. open_project
            RegisterTool(new McpTool
            {
                Name = "open_project",
                Description = "Opens a Zuken E3.series project file (.e3s).",
                InputSchema = new McpInputSchema
                {
                    Type = "object",
                    Properties = new Dictionary<string, object>
                    {
                        { "project_path", new { type = "string", description = "Absolute file path to the .e3s project file." } }
                    },
                    Required = new List<string> { "project_path" }
                }
            }, OpenProjectHandler);

            // 4. close_project
            RegisterTool(new McpTool
            {
                Name = "close_project",
                Description = "Closes the currently active Zuken E3.series project.",
                InputSchema = new McpInputSchema { Type = "object" }
            }, CloseProjectHandler);

            // 5. search_devices
            RegisterTool(new McpTool
            {
                Name = "search_devices",
                Description = "Searches for devices, connectors, or cables in the active project matching a query string.",
                InputSchema = new McpInputSchema
                {
                    Type = "object",
                    Properties = new Dictionary<string, object>
                    {
                        { "query", new { type = "string", description = "Query string matching device name, component, location, or assignment." } }
                    },
                    Required = new List<string> { "query" }
                }
            }, SearchDevicesHandler);

            // 6. get_device_details
            RegisterTool(new McpTool
            {
                Name = "get_device_details",
                Description = "Retrieves pins, attributes, and properties of a device by ID.",
                InputSchema = new McpInputSchema
                {
                    Type = "object",
                    Properties = new Dictionary<string, object>
                    {
                        { "device_id", new { type = "integer", description = "Unique integer ID of the device." } }
                    },
                    Required = new List<string> { "device_id" }
                }
            }, GetDeviceDetailsHandler);

            // 7. rename_device
            RegisterTool(new McpTool
            {
                Name = "rename_device",
                Description = "Renames a device identifier tag in the project.",
                InputSchema = new McpInputSchema
                {
                    Type = "object",
                    Properties = new Dictionary<string, object>
                    {
                        { "device_id", new { type = "integer", description = "Unique integer ID of the device." } },
                        { "new_name", new { type = "string", description = "New device name tag." } }
                    },
                    Required = new List<string> { "device_id", "new_name" }
                }
            }, RenameDeviceHandler);

            // 8. export_sheet_image
            RegisterTool(new McpTool
            {
                Name = "export_sheet_image",
                Description = "Exports a drawing sheet to an image file (PNG/JPG).",
                InputSchema = new McpInputSchema
                {
                    Type = "object",
                    Properties = new Dictionary<string, object>
                    {
                        { "sheet_id", new { type = "integer", description = "Unique integer ID of the sheet." } },
                        { "filename", new { type = "string", description = "Absolute file path destination to save the image (e.g. .png / .jpg)." } }
                    },
                    Required = new List<string> { "sheet_id", "filename" }
                }
            }, ExportSheetImageHandler);

            // 9. search_knowledge_base
            RegisterTool(new McpTool
            {
                Name = "search_knowledge_base",
                Description = "Queries local vector knowledge database using nomic-embed-text RAG model search.",
                InputSchema = new McpInputSchema
                {
                    Type = "object",
                    Properties = new Dictionary<string, object>
                    {
                        { "query", new { type = "string", description = "Natural language search prompt query." } },
                        { "mode", new { type = "string", description = "Search mode: 'rag' (default vector search) or 'keyword' (fallback DB match)." } },
                        { "ollama_url", new { type = "string", description = "Ollama service base URL (optional, defaults to OLLAMA_URL env var or http://localhost:11434)." } }
                    },
                    Required = new List<string> { "query" }
                }
            }, SearchKnowledgeBaseHandler);

            // 10. run_script
            RegisterTool(new McpTool
            {
                Name = "run_script",
                Description = "Compiles and executes a C# Roslyn script dynamically against the active Zuken E3.series session inside the STA thread. Scripts can call Log(object) to write diagnostic messages.",
                InputSchema = new McpInputSchema
                {
                    Type = "object",
                    Properties = new Dictionary<string, object>
                    {
                        { "script_code", new { type = "string", description = "C# script code to compile and execute." } }
                    },
                    Required = new List<string> { "script_code" }
                }
            }, RunScriptHandler);
        }

        private void RegisterTool(McpTool tool, Func<JsonElement?, Task<McpToolCallResult>> handler)
        {
            _tools.Add(tool);
            _toolHandlers[tool.Name] = handler;
        }

        public async Task StartAsync()
        {
            using var reader = new StreamReader(Console.OpenStandardInput());
            while (true)
            {
                var line = await reader.ReadLineAsync();
                if (line == null) break; // End of stream

                try
                {
                    var request = JsonSerializer.Deserialize<McpRequest>(line);
                    if (request != null)
                    {
                        var response = await HandleRequestAsync(request);
                        var responseJson = JsonSerializer.Serialize(response);
                        Console.WriteLine(responseJson);
                        Console.Out.Flush();
                    }
                }
                catch (Exception ex)
                {
                    var errResponse = new McpResponse
                    {
                        Error = new McpError { Code = -32603, Message = $"Internal error: {ex.Message}" }
                    };
                    Console.WriteLine(JsonSerializer.Serialize(errResponse));
                    Console.Out.Flush();
                }
            }
        }

        private async Task<McpResponse> HandleRequestAsync(McpRequest request)
        {
            var response = new McpResponse { Id = request.Id };

            switch (request.Method)
            {
                case "initialize":
                    response.Result = new McpInitializeResult();
                    break;

                case "tools/list":
                    response.Result = new McpToolListResult { Tools = _tools };
                    break;

                case "tools/call":
                    if (request.Params.HasValue && request.Params.Value.TryGetProperty("name", out var nameProp))
                    {
                        string toolName = nameProp.GetString() ?? string.Empty;
                        request.Params.Value.TryGetProperty("arguments", out var argsProp);

                        if (_toolHandlers.TryGetValue(toolName, out var handler))
                        {
                            try
                            {
                                response.Result = await handler(argsProp);
                            }
                            catch (Exception ex)
                            {
                                response.Result = new McpToolCallResult
                                {
                                    IsError = true,
                                    Content = new List<McpContent> { new McpContent { Text = $"Tool execution error: {ex.Message}" } }
                                };
                            }
                        }
                        else
                        {
                            response.Error = new McpError { Code = -32601, Message = $"Tool not found: {toolName}" };
                        }
                    }
                    else
                    {
                        response.Error = new McpError { Code = -32602, Message = "Missing tool name parameter." };
                    }
                    break;

                default:
                    response.Error = new McpError { Code = -32601, Message = $"Method not found: {request.Method}" };
                    break;
            }

            return response;
        }

        // ==========================================
        // TOOL HANDLERS (CALLING TIER 2 SERVICES)
        // ==========================================

        private Task<McpToolCallResult> GetProjectStatusHandler(JsonElement? args)
        {
            return Task.Run(() =>
            {
                var status = _projectService.GetProjectStatus();
                if (!status.Connected)
                {
                    return new McpToolCallResult
                    {
                        IsError = true,
                        Content = new List<McpContent> { new McpContent { Text = "E3.series is not running or COM connection failed." } }
                    };
                }

                if (!status.ActiveProject)
                {
                    return new McpToolCallResult
                    {
                        Content = new List<McpContent> { new McpContent { Text = "Connected to Zuken E3.series, but no active project is open." } }
                    };
                }

                var statusInfo = $"Connected to Zuken E3.series {status.Version} {(status.IsStudent ? "(Educational)" : "(Professional)")}\n" +
                                 $"Active Project: {status.ProjectName}\n" +
                                 $"Path: {status.ProjectPath}\n" +
                                 $"Project ID: {status.ProjectId}";

                return new McpToolCallResult
                {
                    Content = new List<McpContent> { new McpContent { Text = statusInfo } }
                };
            });
        }

        private Task<McpToolCallResult> ListSheetsHandler(JsonElement? args)
        {
            return Task.Run(() =>
            {
                var sheets = _schematicService.ListSheets();
                var sheetsList = new List<string>();
                foreach (var sheet in sheets)
                {
                    sheetsList.Add($"- ID: {sheet.Id}, Name: {sheet.Name}");
                }

                var textResult = sheetsList.Count > 0 
                    ? $"Found {sheetsList.Count} sheets in project:\n" + string.Join("\n", sheetsList)
                    : "No sheets found in this project.";

                return new McpToolCallResult
                {
                    Content = new List<McpContent> { new McpContent { Text = textResult } }
                };
            });
        }

        private Task<McpToolCallResult> OpenProjectHandler(JsonElement? args)
        {
            return Task.Run(() =>
            {
                string path = args?.GetProperty("project_path").GetString() ?? string.Empty;
                if (string.IsNullOrEmpty(path))
                {
                    return new McpToolCallResult { IsError = true, Content = new() { new() { Text = "Project path is required." } } };
                }

                if (_projectService.OpenProject(path))
                {
                    return new McpToolCallResult { Content = new() { new() { Text = $"Successfully opened project: {path}" } } };
                }
                return new McpToolCallResult { IsError = true, Content = new() { new() { Text = $"Failed to open project: {path}. Check if file path is correct and file is not locked." } } };
            });
        }

        private Task<McpToolCallResult> CloseProjectHandler(JsonElement? args)
        {
            return Task.Run(() =>
            {
                if (_projectService.CloseProject())
                {
                    return new McpToolCallResult { Content = new() { new() { Text = "Successfully closed the active project." } } };
                }
                return new McpToolCallResult { IsError = true, Content = new() { new() { Text = "Failed to close the project." } } };
            });
        }

        private Task<McpToolCallResult> SearchDevicesHandler(JsonElement? args)
        {
            return Task.Run(() =>
            {
                string query = args?.GetProperty("query").GetString()?.ToLower() ?? string.Empty;
                var results = _schematicService.SearchDevices(query);

                string json = JsonSerializer.Serialize(results, new JsonSerializerOptions { WriteIndented = true });
                return new McpToolCallResult { Content = new() { new() { Text = json } } };
            });
        }

        private Task<McpToolCallResult> GetDeviceDetailsHandler(JsonElement? args)
        {
            return Task.Run(() =>
            {
                int devId = args?.GetProperty("device_id").GetInt32() ?? 0;
                if (devId == 0)
                    return new McpToolCallResult { IsError = true, Content = new() { new() { Text = "Device ID is required." } } };

                var details = _schematicService.GetDeviceDetails(devId);
                if (details == null)
                    return new McpToolCallResult { IsError = true, Content = new() { new() { Text = $"Device ID {devId} not found." } } };

                string json = JsonSerializer.Serialize(details, new JsonSerializerOptions { WriteIndented = true });
                return new McpToolCallResult { Content = new() { new() { Text = json } } };
            });
        }

        private Task<McpToolCallResult> RenameDeviceHandler(JsonElement? args)
        {
            return Task.Run(() =>
            {
                int devId = args?.GetProperty("device_id").GetInt32() ?? 0;
                string newName = args?.GetProperty("new_name").GetString() ?? string.Empty;

                if (devId == 0 || string.IsNullOrEmpty(newName))
                    return new McpToolCallResult { IsError = true, Content = new() { new() { Text = "Device ID and new name are required." } } };

                if (_schematicService.RenameDevice(devId, newName, out string oldName, out string errorMessage))
                {
                    return new McpToolCallResult { Content = new() { new() { Text = $"Successfully renamed device from '{oldName}' to '{newName}'." } } };
                }
                return new McpToolCallResult { IsError = true, Content = new() { new() { Text = $"Rename failed: {errorMessage}" } } };
            });
        }

        private Task<McpToolCallResult> ExportSheetImageHandler(JsonElement? args)
        {
            return Task.Run(() =>
            {
                int sheetId = args?.GetProperty("sheet_id").GetInt32() ?? 0;
                string filename = args?.GetProperty("filename").GetString() ?? string.Empty;

                if (sheetId == 0 || string.IsNullOrEmpty(filename))
                    return new McpToolCallResult { IsError = true, Content = new() { new() { Text = "Sheet ID and filename are required." } } };

                if (_exportService.ExportSheetImage(sheetId, filename))
                {
                    return new McpToolCallResult { Content = new() { new() { Text = $"Successfully exported sheet {sheetId} to '{filename}'." } } };
                }
                return new McpToolCallResult { IsError = true, Content = new() { new() { Text = $"Failed to export sheet image to '{filename}'." } } };
            });
        }

        private async Task<McpToolCallResult> SearchKnowledgeBaseHandler(JsonElement? args)
        {
            string query = args?.GetProperty("query").GetString() ?? string.Empty;
            string mode = "rag";
            if (args != null && args.Value.TryGetProperty("mode", out var modeProp))
            {
                mode = modeProp.GetString() ?? "rag";
            }

            string? ollamaUrl = null;
            if (args != null && args.Value.TryGetProperty("ollama_url", out var urlProp))
            {
                ollamaUrl = urlProp.GetString();
            }

            if (string.IsNullOrEmpty(query))
            {
                return new McpToolCallResult { IsError = true, Content = new() { new() { Text = "Query parameter is required." } } };
            }

            try
            {
                var matches = await RagSearcher.SearchKnowledgeBaseAsync(query, mode, ollamaUrl);
                var textResult = new System.Text.StringBuilder();
                textResult.AppendLine($"### Vector Knowledge Base results for '{query}' (Mode: {mode})");
                if (matches.Count == 0)
                {
                    textResult.AppendLine("No matching documents found in vector knowledge base.");
                }
                else
                {
                    foreach (var match in matches)
                    {
                        textResult.AppendLine($"\n- **Document**: `{match.Filename}` (Category: *{match.Category}*, Similarity: *{match.Similarity:F4}*)");
                        textResult.AppendLine($"  ```markdown\n{match.Content}\n  ```");
                    }
                }

                return new McpToolCallResult
                {
                    Content = new List<McpContent> { new McpContent { Text = textResult.ToString() } }
                };
            }
            catch (Exception ex)
            {
                return new McpToolCallResult
                {
                    IsError = true,
                    Content = new List<McpContent> { new McpContent { Text = $"RAG search error: {ex.Message}" } }
                };
            }
        }

        private Task<McpToolCallResult> RunScriptHandler(JsonElement? args)
        {
            return Task.Run(() =>
            {
                string code = args?.GetProperty("script_code").GetString() ?? string.Empty;
                if (string.IsNullOrEmpty(code))
                {
                    return new McpToolCallResult { IsError = true, Content = new() { new() { Text = "script_code is required." } } };
                }

                var output = _scriptService.RunScript(code);
                return new McpToolCallResult { Content = new() { new() { Text = output } } };
            });
        }
    }
}

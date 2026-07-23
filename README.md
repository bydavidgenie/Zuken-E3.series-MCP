# Zuken E3.series Model Context Protocol (MCP) Server

[![Model Context Protocol](https://img.shields.io/badge/MCP-Protocol-blue.svg)](https://modelcontextprotocol.io)
[![.NET Version](https://img.shields.io/badge/.NET-10.0--windows-blueviolet.svg)](https://dotnet.microsoft.com/download)
[![Language](https://img.shields.io/badge/Language-C#%20%2F%20Python-green.svg)](#)

An implementation of the **Model Context Protocol (MCP)** server for **Zuken E3.series**, enabling LLM agents (like Claude Desktop, Windsurf, or Cursor) to interact directly with Zuken E3.series electrical engineering CAD software.

Through this server, an AI assistant can inspect project sheets, search for components/cables/connectors, query pin configurations, automatically rename device designations, export drawings as images, and execute dynamic C# Roslyn scripts directly within the E3.series STA COM thread.

---

## 🏗️ Architecture & Features

This repository provides two implementations of the MCP server:
1. **C# Server (`ZukenE3Mcp`) [Preferred]**: Built using .NET 10.0-windows, implementing native COM Interop wrapper APIs and a C# Roslyn compilation engine.
2. **Python Server (`mcp_server.py`)**: Built using Python's `win32com` and the `FastMCP` framework.

### 🌟 Key Features
- **Project Lifecycle Control**: Open, close, and monitor active project states (`.e3s` files).
- **Schematic Inspection**: List sheets, search for devices/connectors/cables, and read pins and custom attributes.
- **Design Modification**: Rename device designations (e.g., changing device tags safely).
- **Drawing Export**: Export specific drawing sheets directly to high-quality PNG/JPG images.
- **Local Knowledge RAG**: Semantic vector query search against project wikis, graph databases, or reference manuals.
- **Roslyn Scripting Sandbox**: Allows the LLM to write and run dynamic C# scripting commands directly on Zuken's active workspace.

---

## 📁 Repository Structure

```bash
├── ZukenE3Mcp.slnx        # Visual Studio XML-based Solution file
├── ZukenE3Mcp/            # C# MCP Server Project
│   ├── API/               # Zuken COM API wrappers (v2025, v2026, v2027)
│   ├── Protocol/          # MCP JSON-RPC protocol implementation
│   ├── Services/          # Core schematic, export, project, and scripting services
│   ├── Tools/             # MCP Tool definitions
│   └── Program.cs         # C# executable entry point
├── static/                # Web Dashboard / Frontend UI files
│   ├── index.html         # Main dashboard page
│   ├── app.js             # UI controls
│   └── styles.css         # UI CSS styling
├── wiki/                  # Project markdown guides and documentation
├── mcp_server.py          # Alternative Python MCP server
└── main.py                # Python launcher utility
```

---

## 🛠️ Requirements & Installation

### Prerequisites
*   **OS**: Windows (Required for Zuken COM Interop)
*   **Zuken E3.series** installed (v2025, v2026, or v2027)
*   For the C# Server: **.NET 10.0 SDK** (Windows)
*   For the Python Server: **Python 3.10+**

### C# Server Setup
1. Open the solution file `ZukenE3Mcp.slnx` using Visual Studio 2022 or compile via command line.
2. Set the target Zuken E3.series version build property. By default, it targets `2027`. You can pass the version using MSBuild properties:
   ```bash
   dotnet build -p:ZukenVersion=2027
   ```
3. Run the executable to start the stdio server stream:
   ```bash
   dotnet run --project ZukenE3Mcp/ZukenE3Mcp.csproj --property ZukenVersion=2027
   ```

### Python Server Setup
1. Install Python dependencies:
   ```bash
   pip install mcp pythoncom pypiwin32 networkx httpx
   ```
2. Run the python script:
   ```bash
   python mcp_server.py
   ```

---

## 🔌 Integrating with Claude Desktop / AI IDEs

To connect the server to Claude Desktop, add the server to your `claude_desktop_config.json`:

### C# Server Configuration (Recommended)
```json
{
  "mcpServers": {
    "zuken-e3-mcp-cs": {
      "command": "C:\\Program Files\\dotnet\\dotnet.exe",
      "args": [
        "run",
        "--project",
        "C:\\CODE\\Zuken_E3.series_2027\\ZukenE3Mcp\\ZukenE3Mcp.csproj",
        "--property",
        "ZukenVersion=2027"
      ],
      "env": {
        "preferred_version": "2027"
      }
    }
  }
}
```

### Python Server Configuration
```json
{
  "mcpServers": {
    "zuken-e3-mcp-py": {
      "command": "python",
      "args": [
        "C:\\CODE\\Zuken_E3.series_2027\\mcp_server.py"
      ]
    }
  }
}
```

---

## 🛠️ Exposed MCP Tools

The server registers the following tools to the MCP host:

| Tool Name | Parameters | Description |
| :--- | :--- | :--- |
| `get_project_status` | None | Returns the active project name, path, database source, and schematic statistics. |
| `list_sheets` | None | Lists all drawings/sheets in the active project. |
| `open_project` | `project_path` (string) | Opens a specific `.e3s` drawing file. |
| `close_project` | None | Closes the current project. |
| `search_devices` | `query` (string) | Searches for devices, cables, and connectors. |
| `get_device_details`| `device_id` (integer) | Retrieves detailed pin connection lists and custom attributes for a device. |
| `rename_device` | `device_id` (integer), `new_name` (string) | Renames a device code designation safely in the project database. |
| `export_sheet_image`| `sheet_id` (integer), `filename` (string) | Exports a schematic page layout to a local image format file. |
| `search_knowledge_base`| `query` (string), `mode` (string) | Conducts RAG vector search or Graph-RAG queries over local developer guides. |
| `run_script` | `script_code` (string) | Compiles and executes a dynamic C# Roslyn script directly on the E3.series session thread. |

---

## 🔒 Security & Git Best Practices
The following local files are excluded from this repository via `.gitignore` to protect license constraints and storage limits:
- `E3API-Reference_u.chm` (Zuken's Proprietary API help file)
- Large binary databases (`vector_knowledge.db` - 170MB, contains embedded Zuken data)
- Build output directories (`bin/`, `obj/`, `__pycache__/`, `temp_cache/`)

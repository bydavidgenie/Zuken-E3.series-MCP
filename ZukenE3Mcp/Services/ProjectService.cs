using System;
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
    public class ProjectService
    {
        public class ProjectStatusResult
        {
            public bool Connected { get; set; }
            public bool ActiveProject { get; set; }
            public string ProjectName { get; set; } = string.Empty;
            public string ProjectPath { get; set; } = string.Empty;
            public string Version { get; set; } = string.Empty;
            public bool IsStudent { get; set; }
            public int ProjectId { get; set; }
        }

        public ProjectStatusResult GetProjectStatus()
        {
            using var e3App = E3ComConnector.GetE3Application();
            if (e3App == null)
            {
                return new ProjectStatusResult { Connected = false };
            }

            using var job = e3App.CreateJobObject();
            int prjId = job.GetId();
            if (prjId == 0)
            {
                return new ProjectStatusResult
                {
                    Connected = true,
                    ActiveProject = false,
                    Version = e3App.GetVersion(),
                    IsStudent = e3App.IsStudent() != 0
                };
            }

            return new ProjectStatusResult
            {
                Connected = true,
                ActiveProject = true,
                ProjectName = job.GetName(),
                ProjectPath = job.GetPath(),
                Version = e3App.GetVersion(),
                IsStudent = e3App.IsStudent() != 0,
                ProjectId = prjId
            };
        }

        public bool OpenProject(string projectPath)
        {
            using var e3App = E3ComConnector.GetE3Application();
            if (e3App == null) return false;

            using var job = e3App.CreateJobObject();
            int prjId = job.GetId();
            if (prjId != 0)
            {
                job.Close();
            }

            return job.Open(projectPath) == 1;
        }

        public bool CloseProject()
        {
            using var e3App = E3ComConnector.GetE3Application();
            if (e3App == null) return false;

            using var job = e3App.CreateJobObject();
            if (job.GetId() == 0) return true; // Already closed

            return job.Close() == 1;
        }
    }
}

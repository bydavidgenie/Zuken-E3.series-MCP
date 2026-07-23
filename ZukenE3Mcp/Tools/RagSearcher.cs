using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ZukenE3Mcp.Tools
{
    public static class PathResolver
    {
        public static string ResolvePath(string relativePath)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            while (!string.IsNullOrEmpty(baseDir))
            {
                string candidate = Path.Combine(baseDir, relativePath);
                if (File.Exists(candidate) || Directory.Exists(candidate))
                {
                    return Path.GetFullPath(candidate);
                }
                string? parent = Directory.GetParent(baseDir)?.FullName;
                if (parent == baseDir) break;
                baseDir = parent ?? string.Empty;
            }
            // Fallback to environment variable or current directory
            string? envRoot = Environment.GetEnvironmentVariable("ZUKEN_WORKSPACE_ROOT");
            if (!string.IsNullOrEmpty(envRoot))
            {
                return Path.Combine(envRoot, relativePath);
            }
            return Path.Combine(Directory.GetCurrentDirectory(), relativePath);
        }
    }

    public class RagSearcher
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        private static string GetDefaultOllamaUrl()
        {
            return Environment.GetEnvironmentVariable("OLLAMA_URL") ?? "http://localhost:11434";
        }

        public class SearchResult
        {
            public string Filename { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public double Similarity { get; set; }
        }

        public static async Task<List<SearchResult>> SearchKnowledgeBaseAsync(string query, string mode = "rag", string? ollamaUrl = null)
        {
            ollamaUrl ??= GetDefaultOllamaUrl();
            if (mode != "rag")
            {
                // Simple keyword fallback search if mode is not RAG
                return KeywordSearch(query);
            }

            string dbPath = PathResolver.ResolvePath("help_source/vector_knowledge.db");
            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException($"Vector database not found at resolved path: {dbPath}");
            }

            // Get embedding for query
            List<float>? queryEmbedding = await GetOllamaEmbeddingAsync(query, ollamaUrl);
            if (queryEmbedding == null || queryEmbedding.Count == 0)
            {
                throw new InvalidOperationException("Failed to fetch vector embedding from Ollama host.");
            }

            var results = new List<SearchResult>();

            using (var conn = new SqliteConnection($"Data Source={dbPath}"))
            {
                await conn.OpenAsync();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id, filename, category, content, embedding FROM knowledge_chunks";
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string filename = reader.GetString(1);
                            string category = reader.GetString(2);
                            string content = reader.GetString(3);
                            string embJson = reader.GetString(4);

                            try
                            {
                                var chunkEmb = JsonSerializer.Deserialize<List<float>>(embJson);
                                if (chunkEmb != null && chunkEmb.Count > 0)
                                {
                                    double similarity = CalculateCosineSimilarity(queryEmbedding, chunkEmb);
                                    results.Add(new SearchResult
                                    {
                                        Filename = filename,
                                        Category = category,
                                        Content = content,
                                        Similarity = similarity
                                    });
                                }
                            }
                            catch (Exception)
                            {
                                // Skip malformed chunks
                            }
                        }
                    }
                }
            }

            results.Sort((x, y) => y.Similarity.CompareTo(x.Similarity));
            return results.Count > 3 ? results.GetRange(0, 3) : results;
        }

        private static List<SearchResult> KeywordSearch(string query)
        {
            var results = new List<SearchResult>();
            string dbPath = PathResolver.ResolvePath("help_source/vector_knowledge.db");
            if (!File.Exists(dbPath)) return results;

            using (var conn = new SqliteConnection($"Data Source={dbPath}"))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT filename, category, content FROM knowledge_chunks WHERE content LIKE @query LIMIT 3";
                    cmd.Parameters.AddWithValue("@query", $"%{query}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new SearchResult
                            {
                                Filename = reader.GetString(0),
                                Category = reader.GetString(1),
                                Content = reader.GetString(2),
                                Similarity = 1.0
                            });
                        }
                    }
                }
            }
            return results;
        }

        private static async Task<List<float>?> GetOllamaEmbeddingAsync(string prompt, string ollamaUrl)
        {
            string url = $"{ollamaUrl.TrimEnd('/')}/api/embeddings";
            var payload = new
            {
                model = "nomic-embed-text:latest",
                prompt = prompt
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            try
            {
                var response = await _httpClient.PostAsync(url, jsonContent);
                if (response.IsSuccessStatusCode)
                {
                    string resJson = await response.Content.ReadAsStringAsync();
                    using (var doc = JsonDocument.Parse(resJson))
                    {
                        if (doc.RootElement.TryGetProperty("embedding", out var embElement))
                        {
                            return JsonSerializer.Deserialize<List<float>>(embElement.GetRawText());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Ollama connection error: {ex.Message}");
            }
            return null;
        }

        private static double CalculateCosineSimilarity(List<float> v1, List<float> v2)
        {
            double dotProduct = 0.0;
            double mag1 = 0.0;
            double mag2 = 0.0;
            int length = Math.Min(v1.Count, v2.Count);

            for (int i = 0; i < length; i++)
            {
                dotProduct += v1[i] * v2[i];
                mag1 += v1[i] * v1[i];
                mag2 += v2[i] * v2[i];
            }

            if (mag1 == 0.0 || mag2 == 0.0) return 0.0;
            return dotProduct / (Math.Sqrt(mag1) * Math.Sqrt(mag2));
        }
    }
}

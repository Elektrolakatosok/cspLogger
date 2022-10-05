using System.Text.Json.Serialization;

namespace cspLogger.Models;

public class CspReportRequest
{
    [JsonPropertyName("csp-report")] public CspReport? CspReport { get; set; }
}
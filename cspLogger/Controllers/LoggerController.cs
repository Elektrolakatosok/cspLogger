using System.Text.Json;
using cspLogger.Models;
using Microsoft.AspNetCore.Mvc;

namespace cspLogger.Controllers;

[ApiController]
[Route("")]
public class LoggerController : ControllerBase
{
    private readonly ILogger<LoggerController> _logger;

    public LoggerController(ILogger<LoggerController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [Route("report")]
    public IActionResult Post([FromBody] CspReportRequest report)
    {
        _logger.LogInformation(JsonSerializer.Serialize(report.CspReport));

        return Ok("");
    }


}
using Microsoft.AspNetCore.Mvc;

namespace CodeGolfValidHtml5WebApi.Controllers;

[ApiController]
[Route("/")]
public class CodeGolfValidHtml5Controller : ControllerBase
{
    private readonly ILogger<CodeGolfValidHtml5Controller> _logger;

    public CodeGolfValidHtml5Controller(ILogger<CodeGolfValidHtml5Controller> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCodeGolfValidHtml5")]
    public ContentResult Get()
    {
        return new ContentResult 
        {
            ContentType = "text/html",
            Content = "<!DOCTYPE html><html lang=\"\"><meta charset=\"UTF-8\"><title>.</title>"
        };
    }
}

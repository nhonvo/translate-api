using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class TranslateController : ControllerBase
{

    private readonly ITranslateService _translateService;

    public TranslateController(ITranslateService translateService)
    {
        _translateService = translateService;
    }

    [HttpPost("from={from}&to={to}")]
    public async Task<IActionResult> Translate(TranslateRequest request, string? from = "en", string? to = "vi")
        => Ok(await _translateService.Translate(request, from, to));
}

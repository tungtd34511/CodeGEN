using Microsoft.AspNetCore.Mvc;
using Starterkit._keenthemes.libs;

namespace Starterkit.Controllers;

public class LayoutsController : Controller
{
    private readonly ILogger<LayoutsController> _logger;
    private readonly IKTTheme _theme;

    public LayoutsController(ILogger<LayoutsController> logger, IKTTheme theme)
    {
        _logger = logger;
        _theme = theme;
    }

    [HttpGet("/")]
    [HttpGet("/layouts/layout-builder")]
    public IActionResult LayoutBuilder()
    {
        return View(_theme.GetPageView("Layouts", "LayoutBuilder.cshtml"));
    }
}

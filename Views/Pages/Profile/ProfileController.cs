using Microsoft.AspNetCore.Mvc;
using Starterkit._keenthemes.libs;

namespace Starterkit.Controllers;

public class ProfileController : Controller
{
    private readonly ILogger<ProfileController> _logger;
    private readonly IKTTheme _theme;

    public ProfileController(ILogger<ProfileController> logger, IKTTheme theme)
    {
        _logger = logger;
        _theme = theme;
    }

    [HttpGet("/")]
    [HttpGet("/Profile")]
    public IActionResult Index()
    {
        return View(_theme.GetPageView("Profile", "Index.cshtml"));
    }
}

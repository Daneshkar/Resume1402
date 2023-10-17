#region Usings

using Microsoft.AspNetCore.Mvc;
using Reume.Application.Services.Interface;

namespace Resume.Presenation.Controllers;

#endregion

public class HomeController : Controller
{
    #region Ctor

    private readonly IDashboardService _dashboardService;

    public HomeController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    #endregion

    public async Task<IActionResult> Index()
    {
        var model = await _dashboardService.FillDashboardModel();

        return View(model);
    }
}
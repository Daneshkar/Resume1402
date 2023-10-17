#region Usings

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Education;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.Experience;
using Resume.Presenation.Models.Entities.MySkills;
using Resume.Presenation.Models.ResumeDbContext;
using Reume.Application.DTOs.SiteSide.Home_Index;
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
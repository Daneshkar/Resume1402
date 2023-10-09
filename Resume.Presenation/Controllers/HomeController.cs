#region Usings

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presenation.Models;
using Resume.Presenation.Models.ResumeDbContext;
using System.Diagnostics;
namespace Resume.Presenation.Controllers;

#endregion

public class HomeController : Controller
{
    #region Ctor

    private readonly ResumeDbContext _context;

    public HomeController(ResumeDbContext context)
    {
        _context = context;
    }

    #endregion

    public async Task<IActionResult> Index()
    {
        #region My Skills 

        //Query With Async
        var mySkillsAsync = await _context.MySkills
                                          .ToListAsync();

        //Query With Synce
        var mySkillsSynce = _context.MySkills
                                    .ToList();

        #endregion

        return View();
    }
}
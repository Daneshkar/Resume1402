#region Usings

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Education;
using Resume.Presenation.Models.Entities.Experience;
using Resume.Presenation.Models.Entities.MySkills;
using Resume.Presenation.Models.ResumeDbContext;
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
        List<MySkills> mySkillsAsync = await _context.MySkills
                                          .ToListAsync();

        //Query With Synce
        List<MySkills> mySkillsSynce = _context.MySkills
                                    .ToList();

        #endregion

        #region Educations

        //Query With Async
        List<Education> educationsAsync = await _context.Educations
                                                        .ToListAsync();

        //Query With Synce
        List<Education> educationsSynce = _context.Educations
                                                  .ToList();

        #endregion

        #region Experience

        //With Async
        List<Experience> experiencesAsync = await _context.Experiences
                                                           .ToListAsync();

        //With Synce
        List<Experience> experiencesSynce = _context.Experiences
                                                    .ToList();

        #endregion

        #region ViewBag() , ViewData[] , TempData[]

        //ViewBag() , ViewData[] , TempData[]

        //ViewBag.Experience = experiencesAsync;

        //ViewBag.MySkills = mySkillsAsync;

        //ViewBag.Educations = educationsAsync;

        #endregion

        return View();
    }
}
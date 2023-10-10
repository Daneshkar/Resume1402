#region Usings

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Education;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.Experience;
using Resume.Presenation.Models.Entities.MySkills;
using Resume.Presenation.Models.ResumeDbContext;
using Reume.Application.DTOs.SiteSide.Home_Index;

namespace Resume.Presenation.Controllers;

#endregion

public class HomeController : Controller
{
    #region Ctor

    private readonly IEducationRepository _educationRepository;
    private readonly IExperienceRepository _experienceRepository;
    private readonly IMySkillsRepsitory _mySkillsRepsitory;

    public HomeController(IEducationRepository educationRepository,
                          IExperienceRepository experienceRepository,
                          IMySkillsRepsitory mySkillsRepsitory)
    {
        _educationRepository = educationRepository;
        _experienceRepository = experienceRepository;
        _mySkillsRepsitory = mySkillsRepsitory;
    }

    #endregion

    public async Task<IActionResult> Index()
    {
        #region My Skills 

        List<MySkills> mySkills = _mySkillsRepsitory.GetListOfMySkills();

        #endregion

        #region Educations

        List<Education> educations = _educationRepository.GetListOFEducations();

        #endregion

        #region Experience

        List<Experience> experiences = _experienceRepository.GetListOfExperience();

        #endregion

        #region Fill Instance Model 

        HomeIndexModelDTO model = new HomeIndexModelDTO();

        model.Experience = experiences;
        model.Educations = educations;
        model.MySkills = mySkills;

        #endregion

        #region ViewBag() , ViewData[] , TempData[]

        //ViewBag() , ViewData[] , TempData[]

        //ViewBag.Experience = experiencesAsync;

        //ViewBag.MySkills = mySkillsAsync;

        //ViewBag.Educations = educationsAsync;

        #endregion

        return View(model);
    }
}
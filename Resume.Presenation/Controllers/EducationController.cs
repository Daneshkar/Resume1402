#region Usings 

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presenation.Models.Entities.Education;
using Resume.Presenation.Models.ResumeDbContext;

namespace Resume.Presenation.Controllers;

#endregion

public class EducationController : Controller
{
    #region Ctor

    public EducationController( )
    {
    }

    #endregion

    #region List Of Educations

    [HttpGet]
    public async Task<IActionResult> ListOfEducations()
    {
        return View();
    }

    #endregion

    #region Create An Education

    public async Task<IActionResult> CreateAnEducation()
    {
        return RedirectToAction(nameof(ListOfEducations));
    }

    #endregion

    #region Delete An Education

    public async Task<IActionResult> DeleteAnEducation(int educationId)
    {
        return RedirectToAction(nameof(ListOfEducations));
    }

    #endregion
}

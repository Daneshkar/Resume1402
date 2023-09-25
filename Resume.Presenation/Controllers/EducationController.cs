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

    //Dependency Injection
    private ResumeDbContext _context;

    public EducationController(ResumeDbContext context )
    {
        _context = context;
    }

    #endregion

    #region List Of Educations

    [HttpGet]
    public async Task<IActionResult> ListOfEducations()
    {
        //Get a Education
        List<Education> education = await _context.Educations
                                                  .ToListAsync();

        return View();
    }

    #endregion

    #region Create An Education

    public async Task<IActionResult> CreateAnEducation()
    {
        #region Fill Education Instance

        Education education = new Education();

        education.EducationDuration = "2022-2023";
        education.EducationTitle = "Military";
        education.Description = "That was ... ";

        #endregion

        #region Add Recorde To The Data Base

        await _context.Educations.AddAsync(education);
        await _context.SaveChangesAsync();

        #endregion

        return RedirectToAction(nameof(ListOfEducations));
    }

    #endregion

    #region Delete An Education

    public async Task<IActionResult> DeleteAnEducation(int educationId)
    {
        #region Find Current Record 

        Education? education = await _context.Educations
                                             .FirstOrDefaultAsync(p=> p.Id == educationId); 

        #endregion

        #region Remove Record 

        _context.Educations.Remove(education);
        await _context.SaveChangesAsync();

        #endregion

        return RedirectToAction(nameof(ListOfEducations));
    }

    #endregion
}

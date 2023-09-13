#region Usings 

using Microsoft.AspNetCore.Mvc;
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
    public IActionResult ListOfEducations()
    {
        //List Of Educations
        var listOfEducations = _context.Educations.ToList();

        //Get a Education
        Education education2 = _context.Educations.OrderByDescending(p=> p.Id).First();

        return View();
    }

    #endregion

    #region Create An Education

    public IActionResult CreateAnEducation()
    {
        #region Create Record

        List<Education> educationList = new List<Education>();

        Education education = new Education()
        {
            Id = 1,
            EducationTitle = "Master",
            EducationDuration = "2012",
            Description = "Degree"
        };

        educationList.Add(education);

        Education educationDataBase = new Education()
        {
            EducationTitle = "Sepehr",
            EducationDuration = "20023",
            Description = "Sepehr"
        };

        _context.Educations.Add(education);
        _context.SaveChanges();

        #endregion

        return View();
    }

    #endregion
}

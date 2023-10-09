#region Using

using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Education;
using Resume.Presenation.Models.ResumeDbContext;
using Reume.Application.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reume.Application.Services.Implementation;

#endregion

public class EducationService : IEducationService
{
    #region Ctor

    //Dependency Injection
    private ResumeDbContext _context;

    public EducationService(ResumeDbContext context)
    {
        _context = context;
    }

    #endregion

    public async Task<List<Education>> GetListOfEducationsAsync()
    {
        List<Education> educations = await _context.Educations
                                                  .ToListAsync();

        return educations;
    }

    public List<Education> GetListOfEducations()
    {
        List<Education> educations = _context.Educations
                                             .ToList();

        return educations;
    }

    public async Task CreateAnEducationAsync(Education education)
    {
        #region Fill Education Instance

        Education education1 = new Education();

        education.EducationDuration = "2022-2023";
        education.EducationTitle = "Military";
        education.Description = "That was ... ";

        #endregion

        #region Add Recorde To The Data Base

        await _context.Educations.AddAsync(education1);
        await _context.SaveChangesAsync();

        #endregion
    }

    public void CreateAnEducation(Education education)
    {
        #region Fill Education Instance

        Education education1 = new Education();

        education.EducationDuration = "2022-2023";
        education.EducationTitle = "Military";
        education.Description = "That was ... ";

        #endregion

        #region Add Recorde To The Data Base

         _context.Educations.Add(education);
         _context.SaveChanges();

        #endregion
    }

    public async Task DeleteAnEducationAsync(int educationId)
    {
        #region Find Current Record 

        Education education = await GetAnEducationByIdAsync(educationId);

        #endregion

        #region Remove Record 

        _context.Educations.Remove(education);
        await _context.SaveChangesAsync();

        #endregion
    }

    public void DeleteAnEducation(int educationId)
    {
        #region Find Current Record 

        Education education = GetAnEducationById(educationId);

        #endregion

        #region Remove Record 

        _context.Educations.Remove(education);
         _context.SaveChanges();

        #endregion
    }

    public async Task<Education> GetAnEducationByIdAsync(int educationId)
    {
        #region Find Current Record 

        Education? education = await _context.Educations
                                             .FirstOrDefaultAsync(p => p.Id == educationId);

        if (education == null) return null;

        #endregion

        return education;
    }

    public Education GetAnEducationById(int educationId)
    {
        #region Get An Education By Id

        Education? education = _context.Educations
                                .FirstOrDefault(p => p.Id == educationId);

        #endregion

        return education;
    }
}

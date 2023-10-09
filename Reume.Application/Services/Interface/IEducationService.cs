#region Using

using Resume.Domain.Models.Entities.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reume.Application.Services.Interface;

#endregion

public interface IEducationService
{
    Task<List<Education>> GetListOfEducationsAsync();

    List<Education> GetListOfEducations();

    Task CreateAnEducationAsync(Education education);

    void CreateAnEducation(Education education);

    Task DeleteAnEducationAsync(int educationId);

    void DeleteAnEducation(int educationId);

    Task<Education> GetAnEducationByIdAsync(int educationId);

    Education GetAnEducationById(int educationId);
}

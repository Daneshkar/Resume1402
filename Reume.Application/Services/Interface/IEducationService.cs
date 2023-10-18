using Resume.Domain.Models.Entities.Education;
using Reume.Application.DTOs.AdminSide.Education;
using System.Collections.Generic;

namespace Reume.Application.Services.Interface;

public interface IEducationService
{
    //GetListOFEducations
    List<Education> GetListOFEducations();

    //Get List Of An Education For Show in Admin Panel 
    List<ListOFAnEducationAdminSideDTO> GetListOfAnEducationForShowinAdminPanel();

    Task AddEducationToDataBase(CreateAnEducationAdminSideDTO model);

    Task<Education> GetAnEducationByIdAsync(int educationId);

    Task EditAnEducation(Education education);

    Task DeleteAnEducation(Education education);
}

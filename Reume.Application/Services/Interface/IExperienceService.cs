using Resume.Domain.Entities.Experience;
using Reume.Application.DTOs.AdminSide.Experience;

namespace Reume.Application.Services.Interface;

public interface IExperienceService
{
    //GetListOfExperience
    List<Experience> GetListOfExperiences();

    //Get List Of An Experience For Show in Admin Panel 
    List<ListOfExperienceAdminSideDTO> GetListOfAnExperienceForShowinAdminPanel();

    Task AddExperienceToDataBase(CreateExperienceAdminSideDTO model);

    Task<Experience> GetAnExperienceByIdAsync(int experienceId);

    Task EditAnExperience(UpdateExperienceAdminSideDTO model);

    Task DeleteAnExperience(Experience experience);
}

using Resume.Domain.Entities.Experience;
using Resume.Domain.RepositoryInterface;
using Reume.Application.DTOs.AdminSide.Experience;
using Reume.Application.Services.Interface;

namespace Reume.Application.Services.Implement;

public class ExperienceService : IExperienceService
{
    #region Ctor

    private readonly IExperienceRepository _experienceRepository;

    public ExperienceService(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    #endregion

    public List<Experience> GetListOfExperiences()
    {
        return _experienceRepository.GetListOfExperience();
    }

    public List<ListOfExperienceAdminSideDTO> GetListOfAnExperienceForShowinAdminPanel()
    {
        //Get List Of An Educations From DataBase   
        List<Experience> experiences = _experienceRepository.GetListOfExperience();

        //Object Mapping
        List<ListOfExperienceAdminSideDTO> returnModel = new List<ListOfExperienceAdminSideDTO>();

        foreach (var exp in experiences)
        {
            ListOfExperienceAdminSideDTO childModel = new ListOfExperienceAdminSideDTO();

            childModel.ExperienceTitle = exp.ExperienceTitle;
            childModel.ExperienceDuration = exp.ExperienceDuration;
            childModel.Id = exp.Id;

            returnModel.Add(childModel);
        }
        ;

        return returnModel;
    }

    public async Task AddExperienceToDataBase(CreateExperienceAdminSideDTO model)
    {
        //Object Mapping 
        Experience experience = new Experience();
        experience.ExperienceDuration = model.ExperienceDuration;
        experience.ExperienceTitle = model.ExperienceTitle;
        experience.CompanyName = model.CompanyName;
        experience.CompanySite = model.CompanySite;
        experience.Description = model.Description;


        await _experienceRepository.AddExperienceToDataBase(experience);
    }

    public async Task<Experience> GetAnExperienceByIdAsync(int experienceId)
    {
        return await _experienceRepository.GetAnExperienceByIdAsync(experienceId);

    }

    public async Task EditAnExperience(Experience experience)
    {
        await _experienceRepository.EditAnExperience(experience);
    }

    public async Task DeleteAnExperience(Experience experience)
    {
        await _experienceRepository.DeleteAnExperience(experience);
    }

}

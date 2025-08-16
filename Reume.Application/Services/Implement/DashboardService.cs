using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Reume.Application.DTOs.SiteSide.Home_Index;
using Reume.Application.Services.Interface;

namespace Reume.Application.Services.Implement;

public class DashboardService : IDashboardService
{
    #region Ctor

    private readonly IEducationService _educationService;
    private readonly IExperienceService _experienceService;
    private readonly IMySkillService _mySkillService;

    public DashboardService(IEducationService educationService,
                          IExperienceService experienceService,
                          IMySkillService mySkillService)
    {
        _educationService = educationService;
        _experienceService = experienceService;
        _mySkillService = mySkillService;
    }

    public async Task<HomeIndexModelDTO> FillDashboardModel()
    {
        #region My Skills 

        List<MySkills> mySkills = _mySkillService.GetListOfMySkills();

        #endregion

        #region Educations

        List<Education> educations = _educationService.GetListOFEducations();

        #endregion

        #region Experience

        List<Experience> experiences = _experienceService.GetListOfExperiences();

        #endregion

        #region Fill Instance Model 

        HomeIndexModelDTO model = new HomeIndexModelDTO();

        model.Experience = experiences;
        model.Educations = educations;
        model.MySkills = mySkills;

        #endregion

        return model;
    }

    #endregion
}

using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.Experience;
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

    public List<Experience> GetListOfExperience()
    {
        return _experienceRepository.GetListOfExperience();
    }
}

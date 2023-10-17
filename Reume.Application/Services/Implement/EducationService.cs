using Resume.Domain.Models.Entities.Education;
using Resume.Domain.RepositoryInterface;
using Reume.Application.Services.Interface;

namespace Reume.Application.Services.Implement;

public class EducationService : IEducationService
{
    private readonly IEducationRepository _educationRepository;

    public EducationService(IEducationRepository educationRepository)
    {
            _educationRepository = educationRepository;
    }

    public List<Education> GetListOFEducations()
    {
        return _educationRepository.GetListOFEducations();
    }
}

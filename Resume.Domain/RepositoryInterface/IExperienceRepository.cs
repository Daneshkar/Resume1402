using Resume.Presenation.Models.Entities.Experience;

namespace Resume.Domain.RepositoryInterface
{
    public interface IExperienceRepository
    {
        //GetListOfExperience
        List<Experience> GetListOfExperience();
    }
}

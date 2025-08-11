using Resume.Domain.Entities.Experience;

namespace Resume.Domain.RepositoryInterface
{
    public interface IExperienceRepository
    {
        //GetListOfExperience
        List<Experience> GetListOfExperience();

        //AdminPanel
        Task AddExperienceToDataBase(Experience experience);

        Task<Experience> GetAnExperienceByIdAsync(int experienceId);

        Task EditAnExperience(Experience experience);

        Task DeleteAnExperience(Experience experience);
    }
}

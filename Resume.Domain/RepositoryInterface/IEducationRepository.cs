using Resume.Domain.Models.Entities.Education;

namespace Resume.Domain.RepositoryInterface
{
    public interface IEducationRepository
    {
        //GetListOFEducations
        List<Education> GetListOFEducations();

        Task AddEducationToDataBase(Education education);

        Task<Education> GetAnEducationByIdAsync(int educationId);

        Task EditAnEducation(Education education);

        Task DeleteAnEducation(Education education);
    }
}

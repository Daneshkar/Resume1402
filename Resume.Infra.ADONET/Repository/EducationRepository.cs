using Resume.Domain.Models.Entities.Education;
using Resume.Domain.RepositoryInterface;

namespace Resume.Infrastructure.EFCore.Repository
{
    public class EducationRepository : IEducationRepository
    {
        //EF Core
        public void AddEducationToDataBase(Education education)
        {
            //Ef Core Code
        }
    }
}

using Resume.Presenation.Models.Entities.MySkills;

namespace Resume.Domain.RepositoryInterface
{
    public interface IMySkillsRepsitory
    {
        //GetListOfMySkills
        List<MySkills> GetListOfMySkills();
    }
}

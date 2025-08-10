using Resume.Domain.Entities.MySkills;

namespace Resume.Domain.RepositoryInterface
{
    public interface IMySkillsRepository
    {
        List<MySkills> GetListOfMySkills();
        MySkills? FindOne(int id);
        void Add(MySkills mySkill);
        void Remove(MySkills mySkill);
        void Update(MySkills mySkills);
    }
}

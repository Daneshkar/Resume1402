using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Reume.Application.Services.Interface;

public interface IMySkillService
{
    List<MySkills> GetListOfMySkills();
    MySkills? FindOne(int id);
    void CreateMySkill(MySkills mySkills);
    void UpdateMySkill(MySkills mySkills);
    void DeleteMySkill(MySkills mySkills);
}

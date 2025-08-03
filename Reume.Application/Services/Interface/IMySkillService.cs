using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.MySkills;

namespace Reume.Application.Services.Interface;

public interface IMySkillService
{
    List<MySkills> GetListOfMySkills();
    MySkills? FindOne(int id);
    void CreateMySkill(MySkills mySkills);
    void UpdateMySkill(MySkills mySkills);
    void DeleteMySkill(MySkills mySkills);
}

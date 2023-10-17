using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.MySkills;
using Reume.Application.Services.Interface;

namespace Reume.Application.Services.Implement;

public class MySkillService : IMySkillService
{
	#region Ctor

	private readonly IMySkillsRepsitory _mySkillsRepsitory;

    public MySkillService(IMySkillsRepsitory mySkillsRepsitory)
    {
        _mySkillsRepsitory = mySkillsRepsitory;
    }

    #endregion

    public List<MySkills> GetListOfMySkills()
    {
        return _mySkillsRepsitory.GetListOfMySkills();
    }
}

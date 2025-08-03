using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.MySkills;
using Resume.Presenation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
    public class MySkillsRepository : IMySkillsRepository
    {
        #region Ctor

        private readonly ResumeDbContext _context;

        public MySkillsRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<MySkills> GetListOfMySkills()
            => _context.MySkills.ToList();

        public MySkills? FindOne(int id)
            => _context.MySkills.Find(id);

        public void Add(MySkills mySkill)
            => _context.MySkills.Add(mySkill);

        public void Remove(MySkills mySkill)
            => _context.MySkills.Remove(mySkill);

        public void Update(MySkills mySkills)
            => _context.MySkills.Update(mySkills);        
    }
}

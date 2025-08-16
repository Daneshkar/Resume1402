using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;

namespace Reume.Application.DTOs.SiteSide.Home_Index;

public class HomeIndexModelDTO
{
    #region properties

    public List<Education> Educations { get; set; }

    public List<Experience> Experience { get; set; }

    public List<MySkills> MySkills { get; set; }

    #endregion
}

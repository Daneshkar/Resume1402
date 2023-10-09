namespace Reume.Application.DTOs.SiteSide.Home_Index;

public class HomeIndexModelDTO
{
    #region properties

    public List<Resume.Domain.Models.Entities.Education.Education> Educations { get; set; }

    public List<Resume.Presenation.Models.Entities.Experience.Experience> Experience { get; set; }

    public List<Resume.Presenation.Models.Entities.MySkills.MySkills> MySkills { get; set; }

    #endregion
}

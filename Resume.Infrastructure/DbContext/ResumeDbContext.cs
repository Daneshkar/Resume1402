#region Using

using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.Models.Entities.Education;
using Resume.Presenation.Models.Entities.Experience;
using Resume.Presenation.Models.Entities.MySkills;

namespace Resume.Presenation.Models.ResumeDbContext;

#endregion

public class ResumeDbContext : DbContext
{
    #region Ctor

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-JCN2C1I\\MSSQLSERVER2019;Initial Catalog=ResumeDaneshkar;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    #endregion

    #region Db Sets

    public DbSet<Experience> Experiences { get; set; }

    public DbSet<MySkills> MySkills { get; set; }

    public DbSet<Education> Educations { get; set; }

    public DbSet<ContactUs> ContactUs { get; set; }

    #endregion
}

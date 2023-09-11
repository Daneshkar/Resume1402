using Microsoft.EntityFrameworkCore;
using Resume.Presenation.Models.Entities.Education;
using Resume.Presenation.Models.Entities.Experience;
using Resume.Presenation.Models.Entities.MySkills;

namespace Resume.Presenation.Models.ResumeDbContext;

public class ResumeDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-JCN2C1I\\MSSQLSERVER2019;Initial Catalog=ResumeDaneshkar;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Experience> Experiences { get; set; }

    public DbSet<MySkills> MySkills { get; set; }

    public DbSet<Education> Educations { get; set; }
}

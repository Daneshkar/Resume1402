
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;
using Resume.Presenation.Models.ResumeDbContext;

namespace Resume.Presenation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IEducationRepository , EducationRepository>();
            builder.Services.AddScoped<IExperienceRepository , ExperienceRepository>();
            builder.Services.AddScoped<IMySkillsRepsitory , MySkillsRepository>();

            builder.Services.AddDbContext<ResumeDbContext>();

            builder.Services.AddScoped<IEducationRepository , EducationRepository>();
            builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
            builder.Services.AddScoped<IMySkillsRepsitory, MySkillsRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
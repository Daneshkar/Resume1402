using System.ComponentModel.DataAnnotations;

namespace Reume.Application.DTOs.AdminSide.Experience
{
    public class CreateExperienceAdminSideDTO
    {
        [Required(ErrorMessage = "عنوان تجربه کاری است")]
        public string ExperienceTitle { get; set; }

        [Required(ErrorMessage = "بازه زمانی تجربه کاری است")]
        public string ExperienceDuration { get; set; }

        [Required(ErrorMessage = "نام شرکت اجباری است")]
        public string CompanyName { get; set; }

        public string? CompanySite { get; set; }

        public string? Description { get; set; }
    }
}

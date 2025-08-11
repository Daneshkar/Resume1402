using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Reume.Application.DTOs.AdminSide.Experience
{
        public  class UpdateExperienceAdminSideDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "عنوان تجربه کاری اجباری است")]
        public string ExperienceTitle { get; set; }

        [Required(ErrorMessage = "بازه زمانی تجربه کاری اجباری است")]
        public string ExperienceDuration { get; set; }

        [Required(ErrorMessage = "نام شرکت اجباری است")]
        public string CompanyName { get; set; }

        public string? CompanySite { get; set; }

        public string? Description { get; set; }
    }
}


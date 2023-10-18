using System.ComponentModel.DataAnnotations;

namespace Reume.Application.DTOs.AdminSide.Education;

public class CreateAnEducationAdminSideDTO
{
    [Required]
    public string EducationTitle { get; set; }

    [Required]
    public string EducationDuration { get; set; }

    [Required]
    public string? Description { get; set; }
}

﻿#region Usings 

using Microsoft.AspNetCore.Mvc;
using Resume.Domain.Models.Entities.Education;
using Reume.Application.Services.Interface;

namespace Resume.Presenation.Controllers;

#endregion

public class EducationController : Controller
{
    #region Ctor

    private readonly IEducationService _educationService;

    public EducationController(IEducationService educationService )
    {
        _educationService = educationService;
    }

    #endregion

    #region List Of Educations

    [HttpGet]
    public async Task<IActionResult> ListOfEducations()
    {
        List<Education> educations = await _educationService.GetListOfEducationsAsync();

        return View(educations);
    }

    #endregion

    #region Create An Education

    public async Task<IActionResult> CreateAnEducation()
    {
        return RedirectToAction(nameof(ListOfEducations));
    }

    #endregion

    #region Delete An Education

    public async Task<IActionResult> DeleteAnEducation(int educationId)
    {
        return RedirectToAction(nameof(ListOfEducations));
    }

    #endregion
}

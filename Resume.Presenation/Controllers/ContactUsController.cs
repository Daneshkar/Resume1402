#region Using

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;
using Reume.Application.DTOs.SiteSide.ContactUs;
using Reume.Application.Services.Interface;

namespace Resume.Presenation.Controllers;

#endregion

public class ContactUsController : Controller
{
    #region Ctor

    private readonly IContactUsService _contactUsService;

    public ContactUsController(IContactUsService contactUsService)
    {
        _contactUsService = contactUsService;
    }

    #endregion

    #region Contact Us 

    public IActionResult ContactUs()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDTO)
    {
        if (ModelState.IsValid)
        {
            await _contactUsService.AddNewContactUsMessage(contactUsDTO);
            return RedirectToAction("Index" , "Home");
        }

        return View();
    }

    #endregion
}

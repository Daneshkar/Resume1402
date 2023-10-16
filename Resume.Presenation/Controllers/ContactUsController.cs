#region Using

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;
using Reume.Application.DTOs.SiteSide.ContactUs;

namespace Resume.Presenation.Controllers;

#endregion

public class ContactUsController : Controller
{
    #region Ctor

    private readonly IContactUsRepository _contactUsRepository;

    public ContactUsController(IContactUsRepository contactUsRepository)
    {
        _contactUsRepository = contactUsRepository;
    }

    #endregion

    #region Contact Us 

    public IActionResult ContactUs()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDTO)
    {
        ContactUs contact = new ContactUs()
        {
            FullName = contactUsDTO.FullName,
            Message = contactUsDTO.Message,
            Mobile = contactUsDTO.Mobile
        };

        ContactUsLocation Location = new ContactUsLocation()
        {
            Address = contactUsDTO.Address,
        };

        //Add To The Data Base
        await _contactUsRepository.AddContactUsToTheDataBase(contact);
        await _contactUsRepository.AddLocationToTheDataBase(Location);

        return View();
    }

    #endregion
}

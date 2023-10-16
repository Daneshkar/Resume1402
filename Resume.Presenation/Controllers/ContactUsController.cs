#region Using

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;

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
    public async Task<IActionResult> ContactUs(ContactUs contact)
    {
        //Add To The Data Base
        await _contactUsRepository.AddContactUsToTheDataBase(contact);

        return View();
    }

    #endregion
}

#region Using

using Microsoft.AspNetCore.Mvc;
namespace Resume.Presenation.Controllers;

#endregion

public class ContactUsController : Controller
{
    #region Ctor



    #endregion

    #region Contact Us 

    public IActionResult ContactUs()
    {
        return View();
    }

    #endregion
}

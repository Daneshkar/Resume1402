#region Using

using Microsoft.AspNetCore.Mvc;
using Resume.Presenation.Models;

namespace Resume.Presenation.Controllers;

#endregion

public class AdminController : Controller
{

    #region Admin Dashboard

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    #endregion

    #region List Of Users

    [HttpPost]
    public IActionResult ListOfUsers(string Email, string Username)
    {
        //Add Email And Username To The Data Base

        return View();
    }

    #endregion
}

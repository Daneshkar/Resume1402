#region Usings

using Microsoft.AspNetCore.Mvc;
namespace Resume.Presenation.Areas.AdminPanel.Controllers;

#endregion

[Area("AdminPanel")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Resume.Presenation.Controllers
{
    public class EducationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

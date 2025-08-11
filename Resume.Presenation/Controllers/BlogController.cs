using Microsoft.AspNetCore.Mvc;

namespace Resume.Presenation.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

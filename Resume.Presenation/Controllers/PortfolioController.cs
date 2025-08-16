using Microsoft.AspNetCore.Mvc;

namespace Resume.Presenation.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

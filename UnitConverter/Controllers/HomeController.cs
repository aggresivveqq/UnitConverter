using Microsoft.AspNetCore.Mvc;

namespace UnitConverter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

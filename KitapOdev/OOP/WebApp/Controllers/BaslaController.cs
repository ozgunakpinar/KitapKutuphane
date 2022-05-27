using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class BaslaController : Controller
    {
        public IActionResult Index()
        {
            return Content("Selam MVC");
        }

        public IActionResult Merhaba()
        {
            return Content("Merhaba MVC");
        }
    }
}

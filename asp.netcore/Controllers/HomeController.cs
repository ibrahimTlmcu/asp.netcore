using Microsoft.AspNetCore.Mvc;

namespace asp.netcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

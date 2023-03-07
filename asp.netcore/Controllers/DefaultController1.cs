using Microsoft.AspNetCore.Mvc;

namespace asp.netcore.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

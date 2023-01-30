using Microsoft.AspNetCore.Mvc;

namespace OperaWebSitee.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

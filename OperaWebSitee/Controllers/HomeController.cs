using System;
using Microsoft.AspNetCore.Mvc;

namespace OperaWebSitee.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido al sistema de Operas";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }
    }
}

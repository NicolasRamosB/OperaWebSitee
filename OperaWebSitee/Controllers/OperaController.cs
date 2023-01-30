using Microsoft.AspNetCore.Mvc;
using OperaWebSite.Models;
using OperaWebSitee.Data;
using System.Linq;

namespace OperaWebSite.Controllers
{
    public class OperaController : Controller
    {
        private readonly DBOperaContext context;

        public OperaController(DBOperaContext context)
        {
            this.context = context;
        }

        //GET /Opera
        //Get /Opera/index
        [HttpGet]
        public IActionResult Index()
        {
            //lista de operas
            var operas = context.Operas.ToList();

            //enviar las operas a la vista
            return View(operas);
        }

        //GET: Opera/Create
        [HttpGet]
        public ActionResult Create()
        {
            Opera opera = new Opera();

            return View("Create", opera);//devolver al cliente html(vista)
        }
        //post: Opera/Create
        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }

        // GET opera/delete/1
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var opera = TraerUna(id);
            if (opera == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", opera);
            }
        }

        //POST opera/Delete/1
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Opera opera = TraerUna(id);
            if (opera == null)
            {
                return NotFound();
            }
            else
            {
                context.Operas.Remove(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }



        //GET Opera/Details/4
        [HttpGet]
        public ActionResult Details(int id)
        {
            Opera opera = TraerUna(id);
            if (opera == null)
            {
                return NotFound();
            }
            else
            {
                return View("detalle", opera);
            }

        }

        //´métodos privados
        private Opera TraerUna(int id)
        {
            return context.Operas.Find(id);
        }
    }
}


using System;
using introduccionCsharp.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using introduccionCsharp.Models;

namespace introduccionCsharp.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba ggggg
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Suma()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Suma(String x, String y, String rl)
        {
            int res = Convert.ToInt16(x) + Convert.ToInt16(y);
            ViewBag.Res = Convert.ToString(res);

            return View();
        }

        public ActionResult Calculos(OperasBas op)
        {
            op.Suma();

            return View(op);
        }

        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new PeliculasService();
            var model = PeliculasService.ObtenerPelicula();

            return View(model);
        }
    }
}
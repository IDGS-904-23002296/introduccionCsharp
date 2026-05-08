using introduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introduccionCsharp.Controllers
{
    public class DistanciaController : Controller
    {
        public ActionResult DistanciaDosPuntos()
        {
            return View(new Distancia());
        }

        [HttpPost]
        public ActionResult DistanciaDosPuntos(Distancia model)
        {
            model.Calcular();
            return View(model);
        }
    }
}

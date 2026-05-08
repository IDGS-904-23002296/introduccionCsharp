using introduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introduccionCsharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        public ActionResult MultiplicacionSuma()
        {
            return View(new MultiplicacionSuma());
        }

        [HttpPost]
        public ActionResult MultiplicacionSuma(MultiplicacionSuma model)
        {
            model.CalcularMultiplicacion();
            return View(model);
        }
    }
}

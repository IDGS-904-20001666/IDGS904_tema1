using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }

	public ActionResult Vista(string numberOne, string numberTwo)
        {
            int result = Convert.ToInt32(numberOne) + Convert.ToInt32(numberTwo);

            ViewBag.Result = Convert.ToString(result);

            return View();
        }

        public ActionResult Calcular(OperasBas operation) 
        {
            var model = new OperasBas();

            model.Operacion = operation.Operacion;
            model.Num1 = operation.Num1;
            model.Num2 = operation.Num2;
            model.Calcular();

            return View(model);
        }

        public ActionResult MostrarPulques() 
        {
            var pulques = new ProductServices();
            var model = pulques.ObtenerProducto();
            return View(model);
        }
    }
}
using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public JsonResult Index()
        {
            var pulque = new Productos()
            {
                Nombre = "Pulque natural",
                Descripcion = "Hecho con aguamiel de la mejor calidad",
                Cantidad = 10,
                Produccion = new DateTime(2023, 05, 12),
            };

            return Json(pulque, JsonRequestBehavior.AllowGet);
            // return Content("<h1>Necesito un salario de 50,000 pesitos al mes :)</h1>");
        }

        public RedirectResult Vista()
        {
            return Redirect("https://youtube.com.mx");
        }

        public RedirectToRouteResult VistaRouteResult()
        {
            TempData["Nombre"] = "Sarahi";
            return RedirectToAction("IndexNuevo");
        }

        public ActionResult IndexNuevo()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "Desarrollo Web Integral";

            string nombre = "";

            if (TempData.ContainsKey("Nombre")) 
            {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.Valor = nombre;

            return View();
        }
    }
}
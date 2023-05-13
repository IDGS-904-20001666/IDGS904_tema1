using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult Index()
        {
            return View();
        }

        public RedirectToRouteResult Calcular(Distancia distancia)
        {
            var model = new Distancia();

            model.EquisUno = distancia.EquisUno;
            model.EquisDos = distancia.EquisDos;
            model.YeUno = distancia.YeUno;
            model.YeDos = distancia.YeDos;
            model.Calcular();

            TempData["ResultadoDist"] = model.Res.ToString();

            return RedirectToAction("Resultado");
        }

        public ActionResult Resultado()
        {
            string resultado = "";

            if (!TempData.ContainsKey("ResultadoDist"))
            {
                return RedirectToAction("Index");
            }
            resultado = TempData["ResultadoDist"] as string;
            ViewBag.Resultado = resultado;
            return View();
        }
    }
}
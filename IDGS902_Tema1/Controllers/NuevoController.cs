using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Ventana() 
        {
            return View();
        }

        public ActionResult OperasBas(string n1, string n2, string radiob) 
        {

            int res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.Res = res;

            return View(); 
        }

        public ActionResult OperaBas2(Calculos op) 
        {
            var model = new Calculos();
            model.Res = op.Num1 + op.Num2;

            ViewBag.Res = model;
            return View(model);
        }

        public ActionResult Puntos(Calculos op)
        {
            var model = new Calculos();
            model.Num1 = op.Num1;
            model.Num2 = op.Num2;
            model.Num3 = op.Num3;
            model.Num4 = op.Num4;
            model.Res = model.OperasBasDistancia();
            return View(model);
        }

        public ActionResult MuestraPulques()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();

            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();

            return View(model);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS902_Tema1.Models; 

namespace IDGS902_Tema1.Controllers
{
    public class CajasController : Controller
    {
        // GET: Cajas
        public ActionResult CajasTexto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GenerarInputs(int numero)
        {
            if (numero< 0 || numero == 0)
            {
                ViewBag.Mensaje = "No se deseó generar ningún input.";
                return View("CajasTexto");
            }

            var inputs = new List<Cajas>();

            for (int i = 0; i < numero; i++)
            {
                inputs.Add(new Cajas
                {
                    Id = $"input_{i}",
                    Name = $"input_{i}",
                    Placeholder = $"Input {i}"
                });
            }

            ViewBag.Inputs = inputs;
            return View("CajasTexto");
        }

        [HttpPost]
        public ActionResult CalcularPromedio(List<int> numeros)
        {

            if (numeros == null || numeros.Count == 0)
            {
                ViewBag.Mensaje = "No se ingresaron números.";
                return View("CajasTexto");
            }

            if (numeros.Any(n => n <= 0))
            {
                ViewBag.Mensaje = "Los números deben ser mayores a 0 o nulo.";
                return View("CajasTexto");
            }

            double promedio = numeros.Sum();
            var numerosRepetidos = numeros.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key).ToList();

            ViewBag.Promedio = promedio;
            ViewBag.NumerosRepetidos = numerosRepetidos;
            return View("CajasTexto");
        }



    }
}
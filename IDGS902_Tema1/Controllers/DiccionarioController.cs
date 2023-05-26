using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;

namespace IDGS902_Tema1.Controllers
{
    public class DiccionarioController : Controller
    {
        private const string rutaArchivo = "/App_Data/palabra.txt";
        private readonly GuardarDService guardarDService;
        private readonly LeerDService leerDService;
        private readonly BuscarDService buscarDService;

        public DiccionarioController()
        {
            guardarDService = new GuardarDService();
            leerDService = new LeerDService();
            buscarDService = new BuscarDService();
        }

        public ActionResult Diccionario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(Palabra palabra)
        {
            palabra.palabraEspañol = palabra.palabraEspañol.ToUpper();
            palabra.palabraIngles = palabra.palabraIngles.ToUpper();
            guardarDService.Guardar(palabra);
            return RedirectToAction("Diccionario");
        }


        [HttpGet]
        public ActionResult Mostrar()
        {
            string rutaCompleta = Server.MapPath(rutaArchivo);
            List<Palabra> palabras = leerDService.LeerPalabras(rutaCompleta);
            return View("Diccionario", palabras);
        }

        public ActionResult DiccionarioBuscador()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Buscar(string palabra, string idioma)
        {
            string rutaCompleta = Server.MapPath(rutaArchivo);
            List<Palabra> palabras = leerDService.LeerPalabras(rutaCompleta);
            string resultado = buscarDService.BuscarPalabra(palabras, palabra, idioma); 
            ViewBag.Resultado = resultado;

            return View("DiccionarioBuscador");
        }


        [HttpPost]
        public ActionResult Ocultar()
        {
            return RedirectToAction("Diccionario");
        }
    }
}

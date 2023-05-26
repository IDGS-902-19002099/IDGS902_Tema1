using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class Pruebas2Controller : Controller
    {
        // GET: Pruebas2
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Edad = 28,
                Email = "jlopez@gmail.com",
                Activo = false,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }
        public ActionResult Escuela()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Edad = 28,
                Email = "jlopez@gmail.com",
                Activo = false,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View(alumno);
        }

    }
}
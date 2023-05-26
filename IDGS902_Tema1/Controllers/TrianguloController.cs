using System;
using System.Reflection;
using System.Web.Mvc;
using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;

namespace IDGS902_Tema1.Controllers
{
    public class TrianguloController : Controller
    {
        //declaracion de la variable trianguloService de la clase service TrianguloService
        public TrianguloService trianguloService;

        //controlador del service
        public TrianguloController()
        {
            trianguloService = new TrianguloService();
        }


        // GET: Triangulo
        public ActionResult DeterminarTriangulo()
        {
            // Crear una instancia del modelo
            Triangulo model = new Triangulo();
            //returna modelo para la vista (para resultado)
            return View(model);
        }

        [HttpPost]
        public ActionResult DeterminarTriangulo(Triangulo triangulo)
        {
            //recibe los valores y las manda a variables
            double x1 = triangulo.x1;
            double y1 = triangulo.y1;
            double x2 = triangulo.x2;
            double y2 = triangulo.y2;
            double x3 = triangulo.x3;
            double y3 = triangulo.y3;

            //invoca el metodo para verificar que sea un triangulo y le envia las variables (las coordenadas)
            bool esTriangulo = trianguloService.EsTriangulo(x1, y1, x2, y2, x3, y3);

            //si el metodo nos returno un valor true significa que si es y procedera a hacer el calculo del area y tipo
            if (esTriangulo)
            {
                //si es triangulo
                triangulo.Resultado = "Es un triángulo";
                //el modelo triangulo es igual al tipo de triangulo segun el metodo aplicado con nuestras coordenadas
                triangulo.TipoTriangulo = trianguloService.ObtenerTipoTriangulo(x1, y1, x2, y2, x3, y3);
                //el modelo triangulo es igual al area del metodo aplicado con nuestras coordenadas
                triangulo.Area = trianguloService.CalcularArea(x1, y1, x2, y2, x3, y3);
            }
            //de lo contrario no es y nos dira un no es
            else
            {
                triangulo.Resultado = "No es un triángulo";
            }
            //returnamos la vista con nuestro triangulo
            return View(triangulo);
        }
    }
}

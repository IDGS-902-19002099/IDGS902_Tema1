using IDGS902_Tema1.Models;
using System;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class GuardarDService
    {
        private const string rutaArchivo = "/App_Data/palabra.txt";

        public void Guardar(Palabra palabra)
        {
            palabra.palabraEspañol = palabra.palabraEspañol.ToUpper();
            palabra.palabraIngles = palabra.palabraIngles.ToUpper();
            string contenido = $"{palabra.palabraEspañol}\t{palabra.palabraIngles}\n";
            string rutaCompleta = HttpContext.Current.Server.MapPath(rutaArchivo);
            System.IO.File.AppendAllText(rutaCompleta, contenido);
        }

    }
}


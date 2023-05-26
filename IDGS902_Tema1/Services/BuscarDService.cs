using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDGS902_Tema1.Services
{
    public class BuscarDService
    {

        public string BuscarPalabra(List<Palabra> palabras, string palabra, string idioma)
        {
            string resultado = "No hay ninguna coincidencia o busca la misma palabra.";
            palabra = palabra.ToUpper(); // Convertir la palabra ingresada a mayúsculas

            if (idioma == "Español")
            {
                Palabra palabraEncontrada = palabras.FirstOrDefault(p => p.palabraIngles.Equals(palabra, StringComparison.InvariantCultureIgnoreCase));

                if (palabraEncontrada != null)
                {
                    resultado = palabraEncontrada.palabraEspañol;
                }
            }
            else if (idioma == "Inglés")
            {
                Palabra palabraEncontrada = palabras.FirstOrDefault(p => p.palabraEspañol.Equals(palabra, StringComparison.InvariantCultureIgnoreCase));

                if (palabraEncontrada != null)
                {
                    resultado = palabraEncontrada.palabraIngles;
                }
            }

            return resultado;
        }




    }
}

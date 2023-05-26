using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace IDGS902_Tema1.Services
{
    public class LeerDService
    {
        public List<Palabra> LeerPalabras(string rutaArchivo)
        {
            List<Palabra> palabras = new List<Palabra>();

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split('\t');

                    if (campos.Length >= 2)
                    {
                        Palabra palabra = new Palabra
                        {
                            palabraEspañol = campos[0],
                            palabraIngles = campos[1]
                        };

                        palabras.Add(palabra);
                    }
                }
            }

            return palabras;
        }
    }
}

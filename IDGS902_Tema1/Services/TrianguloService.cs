using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IDGS902_Tema1.Models;

namespace IDGS902_Tema1.Services
{
    public class TrianguloService
    {
        public bool EsTriangulo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            //calculo de los lados
            double AB = Math.Round(
                Math.Sqrt(
                    Math.Pow(
                        (x2 - x1), 2)
                    +
                    Math.Pow(
                        (y2 - y1)
                        , 2)
                    ),
                2);
            double BC = Math.Round(
                Math.Sqrt(
                    Math.Pow(
                        (x3 - x2), 2) 
                    + 
                    Math.Pow(
                        (y3 - y2),
                        2)
                    ),
                2);
            double CA = Math.Round(
                Math.Sqrt(
                    Math.Pow(
                        (x1 - x3), 2) 
                    +
                    Math.Pow(
                        (y1 - y3)
                        , 2)
                    )
                , 2);
            //se suman todos los lados
            double sumaLados = AB + BC + CA;
            //se busca el valor maximo de los lados para saber cual es el lado mayor
            double LadoMayor = Math.Max(AB, Math.Max(BC, CA));
            //se verifica que la suma de los lados menores sea mayor al lado mayor, si es verdad esto returna true sino false
            return (sumaLados - LadoMayor) > LadoMayor;
        }

        public string ObtenerTipoTriangulo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            //calculo de los lados
            double AB = Math.Round(
                Math.Sqrt(
                    Math.Pow(
                        (x2 - x1)
                        , 2) 
                    + 
                    Math.Pow(
                        (y2 - y1)
                        , 2)
                    )
                ,2);
            double BC = Math.Round(
                Math.Sqrt(
                    Math.Pow(
                        (x3 - x2)
                        , 2) 
                    + 
                    Math.Pow(
                        (y3 - y2)
                        , 2)
                    )
                ,2);
            double CA = Math.Round(
                Math.Sqrt(
                    Math.Pow(
                        (x1 - x3)
                        , 2) 
                    + 
                    Math.Pow(
                        (y1 - y3)
                        , 2)
                    )
                ,2);

            // se hace la comparacion de los lados
            //si son iguales es equilatero
            if (AB == BC && BC == CA)
            {
                return "Equilátero";
            }
            //si dos lados son iguales es isoseles
            else if (AB == BC || BC == CA || CA == AB)
            {
                return "Isósceles";
            }
            //por ultimo si no coincide con lo anterior, significaria que los 3 lados son diferentes 
            else
            {
                return "Escaleno";
            }
        }

        
        public double CalcularArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // toma las coordenadas, saca la diferencia de los lados y se multiplican por coordenada x de cada lado y finalmente se divide entre 2 para obtener el area
            double area = Math.Abs(
                Math.Round(
                    (
                    (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0)
                    , 2)
                );
            //se returna el valor del area
            return area;
        }

    }
}


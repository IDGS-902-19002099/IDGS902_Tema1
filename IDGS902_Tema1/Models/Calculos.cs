using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace IDGS902_Tema1.Models
{
    public class Calculos
    {

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public int Num4 { get; set; }
        public double Res { get; set; }

        public double OperasBasDistancia()
        {
            double r = Math.Sqrt(
                (
                (Math.Pow(((Num3) - (Num4)), 2))
                +
                (Math.Pow(((Num1) - (Num2)), 2))
                )
                );

            return r;
        }


    }


}
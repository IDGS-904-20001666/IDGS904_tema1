using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Distancia
    {
        public double EquisUno { get; set; }

        public double EquisDos { get; set; }

        public double YeUno { get; set; }

        public double YeDos { get; set; }

        public double Res { get; set; }

        public void Calcular()
        {
            Res = Math.Sqrt((EquisDos - EquisUno) * (EquisDos - EquisUno) + (YeDos - YeUno) * (YeDos - YeUno));
        }
    }
}
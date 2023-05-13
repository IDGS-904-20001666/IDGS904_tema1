using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public string Operacion { get; set; }

        public int Res { get; set; }

        public void Calcular()
        {
            switch(Operacion) 
            {
                case "Sumar":
                    Sumar();
                    break;

                case "Restar":
                    Restar();
                    break;

                case "Multiplicar":
                    Multiplicar();
                    break;

                case "Dividir":
                    Dividir();
                    break;

                default:
                    Sumar();
                    break;
            }
        }

        public void Sumar()
        {  
            Res = Num1 + Num2;
        }

        public void Restar()
        {
            Res = Num1 - Num2;
        }

        public void Multiplicar()
        {
            Res = Num1 * Num2;
        }

        public void Dividir()
        {
            Res = Num1 / Num2;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadorWs
{
    public class CalculadoraWs
    {
        public decimal Areacuadrado(decimal dato1, decimal dato2)
        {
            return dato1 * dato2;
        }
        public decimal Areatriangulo(decimal dato1, decimal dato2)
        {
            var resultado = dato1 * dato2;
            return resultado / 2;
        }
        public double Areacirculo(double dato1)
        {
            double pi = 3.14;
            double radio2 = dato1 * dato1;
            return pi * radio2;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculadorWs
{
    /// <summary>
    /// Descripción breve de Calculadoraweb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculadoraweb : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal FormulaCuadrado(decimal lado1, decimal lado2)
        {
            CalculadoraWs o = new CalculadoraWs();
            return o.Areacuadrado(lado1, lado2);

        }
        [WebMethod]
        public decimal FormulaTriangulo(decimal largo, decimal ancho)
        {
            CalculadoraWs o = new CalculadoraWs();
            return o.Areatriangulo(largo, ancho);
        }
        [WebMethod]
        public double FormulaCirculo(double radio)
        {
            CalculadoraWs o = new CalculadoraWs();
            return o.Areacirculo(radio);
        }
    }
}

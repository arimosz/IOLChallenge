using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m),
                new Rectangulo(2,5)
            };

            var reporteIngles = Reporte.Imprimir(formas, new IdiomaIngles());
            var reporteCastellano = Reporte.Imprimir(formas, new IdiomaCastellano());
            var reporteFrances = Reporte.Imprimir(formas, new IdiomaFrances());


            Response.Write(reporteIngles + "<br>" + reporteCastellano + "<br>" + reporteFrances);
            Response.End();            
        }
    }
}
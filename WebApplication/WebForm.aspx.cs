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
                new Triangulo(5),
                new Cuadrado(5),
                new Rectangulo(2,5),
                new Cuadrado(2),
                new Cuadrado(3),
                new Rectangulo(2,5),
                new Rectangulo(2,5),
                new TrapecioIsoceles(1,5,6,1),
                new Triangulo(5)
            };

            var reporteCastellano = Reporte.Imprimir(formas, new IdiomaCastellano());
            var reporteFrances = Reporte.Imprimir(formas, new IdiomaFrances());
            var reporteIngles = Reporte.Imprimir(formas, new IdiomaIngles());


            Response.Write(reporteCastellano); 
            Response.Write(reporteIngles);
            Response.Write(reporteFrances);
            Response.End();            
        }
    }
}
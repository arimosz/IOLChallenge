using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class IdiomaIngles : Idioma
    {
        public override string ImprimirEncabezado()
        {
            return "Shapes report";
        }

        public override string ImprimirEncabezadoVacio() 
        {
            return "Empty list of shapes!";
        }

        public override string ImprimirTituloPerimetro()
        {
            return "Perimeter";
        }

        public override string ImprimirTituloArea()
        {
            return "Area";
        }

        public override string ImprimirTituloTotal()
        {
            return "Total";
        }

        public override string ImprimirTituloForma(int cantidad)
        {
            return cantidad > 1 ? "Shapes" : "Shape";
        }        

        public override string ImprimirNombreCuadrado(int cantidad)
        {
            return cantidad > 1 ? "Squares" : "Square";
        }        

        public override string ImprimirNombreTriangulo(int cantidad)
        {
            return cantidad > 1 ? "Triangles" : "Triangle";
        }        

        public override string ImprimirNombreCirculo(int cantidad)
        {
            return cantidad > 1 ? "Circles" : "Circle";
        }

        public override string ImprimirNombreRectangulo(int cantidad)
        {
            return cantidad > 1 ? "Rectangle" : "Rectangle";
        }

        public override string ImprimirNombreTrapecio(int cantidad)
        {
            return cantidad > 1 ? "Trapezoids" : "Trapeze";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Classes.Enum;

namespace CodingChallenge.Data.Classes
{
    public class IdiomaCastellano : Idioma
    {        
        public override string ImprimirEncabezado()
        {
            return "Reporte de Formas";
        }

        public override string ImprimirEncabezadoVacio()
        {
            return "Lista vacía de formas!";
        }

        public override string ImprimirTituloPerimetro()
        {
            return "Perimetro";
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
            return cantidad > 1 ? "Formas" : "Forma";
        }
        
        public override string ImprimirNombreCuadrado(int cantidad)
        {
            return cantidad > 1 ? "Cuadrados" : "Cuadrado";
        }

        public override string ImprimirNombreTriangulo(int cantidad)
        {
            return cantidad > 1 ? "Triángulos" : "Triángulo";
        }

        public override string ImprimirNombreCirculo(int cantidad)
        {
            return cantidad > 1 ? "Círculos" : "Círculo";
        }

        public override string ImprimirNombreRectangulo(int cantidad)
        {
            return cantidad > 1 ? "Rectangulos" : "Rectangulo";
        }

        public override string ImprimirNombreTrapecio(int cantidad)
        {
            return cantidad > 1 ? "Trapecios" : "Trapecio";
        }
    }
}

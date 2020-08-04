using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class IdiomaFrances : Idioma
    {
        public override string ImprimirEncabezado()
        {
            return "Rapport sur les formes";
        }

        public override string ImprimirEncabezadoVacio()
        {
            return "Liste vide de formes!";
        }

        public override string ImprimirTituloPerimetro()
        {
            return "Périmètre";
        }

        public override string ImprimirTituloArea()
        {
            return "surface";
        }

        public override string ImprimirTituloTotal()
        {
            return "Total";
        }

        public override string ImprimirTituloForma(int cantidad)
        {
            return cantidad > 1 ? "Formes" : "Forme";
        }

        public override string ImprimirNombreCuadrado(int cantidad)
        {
            return cantidad > 1 ? "Carrés" : "Carré";
        }

        public override string ImprimirNombreTriangulo(int cantidad)
        {
            return cantidad > 1 ? "Triangles" : "Triangle";
        }

        public override string ImprimirNombreCirculo(int cantidad)
        {
            return cantidad > 1 ? "Cercles" : "Cercle";
        }

        public override string ImprimirNombreRectangulo(int cantidad)
        {
            return cantidad > 1 ? "Rectangles" : "Rectangle";
        }

        public override string ImprimirNombreTrapecio(int cantidad)
        {
            return cantidad > 1 ? "Trapèzes" : "Trapèze";
        }
    }
}

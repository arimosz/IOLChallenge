using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        public abstract string ImprimirEncabezado();

        public abstract string ImprimirEncabezadoVacio();

        public abstract string ImprimirTituloPerimetro();

        public abstract string ImprimirTituloArea();

        public abstract string ImprimirTituloTotal();

        public abstract string ImprimirTituloForma(int cantidad);

        public abstract string ImprimirNombreCuadrado(int cantidad);

        public abstract string ImprimirNombreTriangulo(int cantidad);

        public abstract string ImprimirNombreCirculo(int cantidad);

        public abstract string ImprimirNombreRectangulo(int cantidad);

        public abstract string ImprimirNombreTrapecio(int cantidad);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Classes.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public decimal lado1;
        public decimal lado2;

        public override FORMAGEOMETRICA GetFormaGeometrica()
        {
            return FORMAGEOMETRICA.RECTANGULO;
        }

        public Rectangulo(decimal lado1, decimal lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            SetPropiedades();
        }

        public override void SetPropiedades()
        {
            area = CalcularArea();
            perimetro = CalcularPerimetro();
            tipo = GetFormaGeometrica();
        }

        public override decimal CalcularArea()
        {
            return lado1 * lado2;
        }

        public override decimal CalcularPerimetro()
        {
            return lado1 * 2 + lado2 * 2;
        }
    }
}

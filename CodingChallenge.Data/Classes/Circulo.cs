using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Classes.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public decimal lado;

        public override FORMAGEOMETRICA GetFormaGeometrica()
        {
            return FORMAGEOMETRICA.CIRCULO;
        }

        public Circulo(decimal lado)
        {
            this.lado = lado;
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
            return (decimal)Math.PI * (lado / 2) * (lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * lado;
        }

        
    }
}

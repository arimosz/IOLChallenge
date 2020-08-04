using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Classes.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {        
        public decimal lado;

        public override FORMAGEOMETRICA GetFormaGeometrica()
        {
            return FORMAGEOMETRICA.CUADRADO;
        }

        public Cuadrado(decimal lado) 
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
            return lado * lado;
        }

        public override decimal CalcularPerimetro()
        {
            return lado * 4;
        }        
    }
}

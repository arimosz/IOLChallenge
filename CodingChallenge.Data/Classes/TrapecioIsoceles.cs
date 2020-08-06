using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Classes.Enum;

namespace CodingChallenge.Data.Classes
{
    public class TrapecioIsoceles : FormaGeometrica
    {
        public decimal ladoMayor;
        public decimal ladoMenor;
        public decimal altura;
        public decimal diagonal;

        public override FORMAGEOMETRICA GetFormaGeometrica()
        {
            return FORMAGEOMETRICA.TRAPECIO;
        }

        public TrapecioIsoceles(decimal ladoMayor, decimal ladoMenor, decimal altura, decimal diagonal)
        {
            this.ladoMayor = ladoMayor;
            this.ladoMenor = ladoMenor;
            this.altura = altura;
            this.diagonal = diagonal;
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
            return ((ladoMayor + ladoMenor) * altura)/2 ;
        }

        public override decimal CalcularPerimetro()
        {
            return ladoMayor + ladoMayor + diagonal * 2;
        }

        public override void AsignarNombresAForma(Idioma idioma)
        {
            nombreFormaSingular = idioma.ImprimirNombreTrapecio(1);
            nombreFormaPlural = idioma.ImprimirNombreTrapecio(2);
        }
    }
}

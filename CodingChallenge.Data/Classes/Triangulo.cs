﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Classes.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo : FormaGeometrica
    {
        public decimal lado;

        public override FORMAGEOMETRICA GetFormaGeometrica()
        {
            return FORMAGEOMETRICA.TRIANGULO;
        }

        public Triangulo(decimal lado)
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
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        public override decimal CalcularPerimetro()
        {
            return lado * 3;
        }

        public override void AsignarNombresAForma(Idioma idioma)
        {
            nombreFormaSingular = idioma.ImprimirNombreTriangulo(1);
            nombreFormaPlural = idioma.ImprimirNombreTriangulo(2);
        }        
    }
}

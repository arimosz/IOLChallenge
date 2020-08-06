/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CodingChallenge.Data.Classes.Enum;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {        
        public FORMAGEOMETRICA tipo;

        public string nombreFormaSingular;

        public string nombreFormaPlural;

        public decimal area;

        public decimal perimetro;        

        public abstract void SetPropiedades();              

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();

        public abstract FORMAGEOMETRICA GetFormaGeometrica();

        public abstract void AsignarNombresAForma(Idioma idioma);         
    }
}

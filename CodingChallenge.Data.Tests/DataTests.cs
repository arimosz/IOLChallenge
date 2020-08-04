using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!<h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), new IdiomaCastellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!<h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), new IdiomaIngles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = Reporte.Imprimir(cuadrados, new IdiomaCastellano());

            Assert.AreEqual("<h1>Reporte de Formas<h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>Total : 1  Forma | Area 25 | Perimetro 20", resumen);
                             
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica> 
            { 
                new Cuadrado(5), 
                new Cuadrado(1), 
                new Cuadrado(3) 
            };            

            var resumen = Reporte.Imprimir(cuadrados, new IdiomaIngles());

            Assert.AreEqual("<h1>Shapes report<h1>3 Squares | Area 35 | Perimeter 36 <br/>Total : 3  Shapes | Area 35 | Perimeter 36", resumen);
                             
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, new IdiomaIngles());

            Assert.AreEqual(
                "<h1>Shapes report<h1>2 Squares | Area 29 | Perimeter 28 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>Total : 7  Shapes | Area 91,65 | Perimeter 97,66",                 
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, new IdiomaCastellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas<h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>Total : 7  Formas | Area 91,65 | Perimetro 97,66",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulosEnFrances()
        {
            var formas = new List<FormaGeometrica>
            {
                new Rectangulo(2, 5)                
            };

            var resumen = Reporte.Imprimir(formas, new IdiomaFrances());

            Assert.AreEqual(
                "<h1>Rapport sur les formes<h1>1 Rectangle | surface 10 | Périmètre 14 <br/>Total : 1  Forme | surface 10 | Périmètre 14",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnFrances()
        {
            var formas = new List<FormaGeometrica>
            {
                new Rectangulo(2, 5),
                new Rectangulo(2, 5),
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Triangulo(4.2m),
                new TrapecioIsoceles(4, 2,1,3),
                new Rectangulo(2, 5)
            };

            var resumen = Reporte.Imprimir(formas, new IdiomaFrances());

            Assert.AreEqual(
                "<h1>Rapport sur les formes<h1>1 Carré | surface 25 | Périmètre 20 <br/>2 Triangles | surface 14,57 | Périmètre 24,6 <br/>1 Cercle | surface 7,07 | Périmètre 9,42 <br/>3 Rectangles | surface 30 | Périmètre 42 <br/>1 Trapèze | surface 3 | Périmètre 14 <br/>Total : 8  Formes | surface 79,64 | Périmètre 110,02",
                resumen);
        }

        [TestCase]
        public void TestResumenListaVaciaEnFrances()
        {
            Assert.AreEqual("<h1>Liste vide de formes!<h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), new IdiomaFrances()));
        }
    }
}

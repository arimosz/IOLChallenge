using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Classes.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Reporte
    {
        public static string Imprimir(List<FormaGeometrica> listFormas, Idioma idioma) 
        {
            var reporte = new StringBuilder();
            
            var contFormas = 0;
            var perimetroTotal = 0m;
            var areaTotal = 0m;

            var numeroCuadrados = 0;
            var numeroTriangulos = 0;
            var numeroCirculos = 0;
            var numeroRectangulos = 0;
            var numeroTrapecios = 0;

            var areaCuadrados = 0m;
            var areaTriangulos = 0m;
            var areaCirculos = 0m;            
            var areaRectangulos = 0m;
            var areaTrapecios = 0m;

            var perimetroCuadrados = 0m;
            var perimetroTriangulos = 0m;
            var perimetroCirculos = 0m;
            var perimetroRectangulos = 0m;
            var perimetroTrapecios = 0m;

            if (listFormas.Any())
            {
                reporte.Append("<h1>" + idioma.ImprimirEncabezado() + "<h1>");

                foreach (FormaGeometrica formaGeometrica in listFormas) 
                {

                    switch (formaGeometrica.tipo) 
                    {
                        case FORMAGEOMETRICA.CUADRADO:
                            numeroCuadrados++;
                            areaCuadrados += formaGeometrica.area;
                            perimetroCuadrados += formaGeometrica.perimetro;
                            break;

                        case FORMAGEOMETRICA.TRIANGULO:
                            numeroTriangulos++;
                            areaTriangulos += formaGeometrica.area;
                            perimetroTriangulos += formaGeometrica.perimetro;
                            break;

                        case FORMAGEOMETRICA.CIRCULO:
                            numeroCirculos++;
                            areaCirculos += formaGeometrica.area;
                            perimetroCirculos += formaGeometrica.perimetro;
                            break;

                        case FORMAGEOMETRICA.RECTANGULO:
                            numeroRectangulos++;
                            areaRectangulos += formaGeometrica.area;
                            perimetroRectangulos += formaGeometrica.perimetro;
                            break;

                        case FORMAGEOMETRICA.TRAPECIO:
                            numeroTrapecios++;
                            areaTrapecios += formaGeometrica.area;
                            perimetroTrapecios += formaGeometrica.perimetro;
                            break;
                    }

                    contFormas++;
                    areaTotal += formaGeometrica.area;
                    perimetroTotal += formaGeometrica.perimetro;
                }

                if (numeroCuadrados > 0)
                    reporte.Append($"{numeroCuadrados} {idioma.ImprimirNombreCuadrado(numeroCuadrados)} | {idioma.ImprimirTituloArea()} {areaCuadrados:#.##} | {idioma.ImprimirTituloPerimetro()} {perimetroCuadrados:#.##} <br/>");                    

                if (numeroTriangulos > 0)
                    reporte.Append($"{numeroTriangulos} {idioma.ImprimirNombreTriangulo(numeroTriangulos)} | {idioma.ImprimirTituloArea()} {areaTriangulos:#.##} | {idioma.ImprimirTituloPerimetro()} {perimetroTriangulos:#.##} <br/>");                    

                if (numeroCirculos > 0)
                    reporte.Append($"{numeroCirculos} {idioma.ImprimirNombreCirculo(numeroCirculos)} | {idioma.ImprimirTituloArea()} {areaCirculos:#.##} | {idioma.ImprimirTituloPerimetro()} {perimetroCirculos:#.##} <br/>");

                if (numeroRectangulos > 0)
                    reporte.Append($"{numeroRectangulos} {idioma.ImprimirNombreRectangulo(numeroRectangulos)} | {idioma.ImprimirTituloArea()} {areaRectangulos:#.##} | {idioma.ImprimirTituloPerimetro()} {perimetroRectangulos:#.##} <br/>");

                if (numeroTrapecios > 0)
                    reporte.Append($"{numeroTrapecios} {idioma.ImprimirNombreTrapecio(numeroTrapecios)} | {idioma.ImprimirTituloArea()} {areaTrapecios:#.##} | {idioma.ImprimirTituloPerimetro()} {perimetroTrapecios:#.##} <br/>");

                reporte.Append($"{idioma.ImprimirTituloTotal()} : {contFormas}  {idioma.ImprimirTituloForma(contFormas)} | {idioma.ImprimirTituloArea()} {areaTotal:#.##} | {idioma.ImprimirTituloPerimetro()} {perimetroTotal:#.##}");
            }
            else             
                reporte.Append("<h1>" + idioma.ImprimirEncabezadoVacio() + "<h1>");
            
        
            return reporte.ToString();
        }
    }
}

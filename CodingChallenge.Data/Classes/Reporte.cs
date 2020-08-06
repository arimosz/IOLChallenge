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

            if (listFormas.Any())
            {
                int totalFormas = 0;

                reporte.Append("<h1>" + idioma.ImprimirEncabezado() + "<h1>");

                foreach (FormaGeometrica formaGeometrica in listFormas)
                {
                    formaGeometrica.AsignarNombresAForma(idioma);
                    totalFormas++;
                }

                var r = listFormas.GroupBy(t => t.tipo)
                            .Select(t => new
                            {
                                FormaGeo = t.Key,
                                Count = t.Count(),
                                Area = t.Sum(ta => ta.area),
                                Perimetro = t.Sum(ta => ta.perimetro),
                                NombreSing = t.First().nombreFormaSingular,
                                NombrePlural = t.First().nombreFormaPlural
                            }).ToList();

                r.ForEach(row => reporte.Append($"{row.Count} {(row.Count > 1 ? row.NombrePlural : row.NombreSing) } | {idioma.ImprimirTituloArea()} {row.Area:#.##} | {idioma.ImprimirTituloPerimetro()} {row.Perimetro:#.##} <br/>"));

                reporte.Append($"{idioma.ImprimirTituloTotal()} : {totalFormas}  {idioma.ImprimirTituloForma(totalFormas)} | {idioma.ImprimirTituloArea()} {listFormas.Sum(d => d.area):#.##} | {idioma.ImprimirTituloPerimetro()} {listFormas.Sum(d => d.perimetro):#.##}");
            }
            else
                reporte.Append("<h1>" + idioma.ImprimirEncabezadoVacio() + "<h1>");
                                                       
            return reporte.ToString();
        }
    }    
}

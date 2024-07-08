using DevelopmentChallenge.Data.Classes.Figuras;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public static class Extensiones
    {
        public static string Imprimir(this List<IFormaGeometrica> listaFormas, Idioma idioma)
        {
            var sb = new StringBuilder();
            DiccionarioIdioma dicIdioma = new DiccionarioIdioma(idioma);

            if (!listaFormas.Any())
            {
                sb.Append(dicIdioma.Mensajes["ListaVacia"]);
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(dicIdioma.Mensajes["ReporteFormas"]);

                int cantidadTotal = 0;
                decimal areaTotal = 0;
                decimal perimetroTotal = 0;


                Array tipoFormas = Enum.GetValues(typeof(TipoForma));
                foreach (TipoForma tipoForma in tipoFormas)
                {
                    if (listaFormas.Exists(f => f.Forma == tipoForma))
                    {
                        int cantidad = listaFormas.Count(f => f.Forma == tipoForma);
                        decimal area = listaFormas.Where(f => f.Forma == tipoForma).Sum(f => f.CalcularArea());
                        decimal perimetro = listaFormas.Where(f => f.Forma == tipoForma).Sum(f => f.CalcularPerimetro());

                        cantidadTotal += cantidad;
                        areaTotal += area;
                        perimetroTotal += perimetro;

                        sb.Append(ObtenerLinea(tipoForma, cantidad, area, perimetro, dicIdioma));
                    }
                }

                // FOOTER
                sb.Append($"{dicIdioma.Mensajes["Total"]}:<br/>{cantidadTotal} {dicIdioma.Mensajes["Formas"]} ");
                sb.Append($"{dicIdioma.Mensajes["Perimetro"]} {perimetroTotal.ToString("#.##")} ");
                sb.Append($"{dicIdioma.Mensajes["Area"]} {areaTotal.ToString("#.##")}");
            }
            return sb.ToString();
        }

        private static string ObtenerLinea(TipoForma tipoForma, int cantidad, decimal area, decimal perimetro, DiccionarioIdioma dicIdioma)
        {
            if (cantidad > 0)
            {
                string sArea = $"{dicIdioma.Mensajes["Area"]} {area:#.##}";
                string sPerimetro = $"{dicIdioma.Mensajes["Perimetro"]} {perimetro:#.##}";
                string nombreForma = Enum.GetName(typeof(Enums.TipoForma), tipoForma);
                string mensajeCantidad = $"{cantidad} " + (cantidad == 1 ? dicIdioma.Mensajes[nombreForma] : dicIdioma.Mensajes[$"{nombreForma}_plural"]);
                string mensaje = $"{mensajeCantidad} | {sArea} | {sPerimetro} <br/>";
                return mensaje;
            }
            return string.Empty;
        }
    }
}

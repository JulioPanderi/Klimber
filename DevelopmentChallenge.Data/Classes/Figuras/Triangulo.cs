using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;


namespace DevelopmentChallenge.Data.Classes.Figuras
{
    public class TrianguloEquilatero : FormaGeometrica, IFormaGeometrica
    {
        public TrianguloEquilatero(decimal ancho) : base(TipoForma.TrianguloEquilatero, Enumerable.Repeat(ancho, 3).ToList()) { }

        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * (base.Lados[0] * base.Lados[0]);
    }
}

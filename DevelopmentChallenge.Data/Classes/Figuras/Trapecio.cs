using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;


namespace DevelopmentChallenge.Data.Classes.Figuras
{
    public class Trapecio : FormaGeometrica, IFormaGeometrica
    {
        private readonly decimal _altura;

        public Trapecio(decimal ladoMayor, decimal ladoMenor, decimal altura)
            : base(
                    TipoForma.Trapecio,
                    new List<decimal>() { ladoMayor, ladoMayor, ladoMenor, ladoMenor }
                  )
        {
            _altura = altura;
        }

        public decimal CalcularArea() => ((base.Lados[0] + base.Lados[2]) / 2) * _altura;
    }
}

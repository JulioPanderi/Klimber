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
        public Trapecio(decimal ladoSuperior, decimal ladoInferior, decimal altura)
            : base(
                    TipoForma.Trapecio,
                    new List<decimal>() { ladoSuperior, ladoSuperior, ladoInferior, ladoInferior },
                    altura
                  )
        { }

        public decimal CalcularArea() => ((base.Lados[0] + base.Lados[2]) / 2) * base._altura;
    }
}

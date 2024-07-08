using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;


namespace DevelopmentChallenge.Data.Classes.Figuras
{
    public class Rectangulo : FormaGeometrica, IFormaGeometrica 
    {
        public Rectangulo(decimal ancho, decimal altura) :
            base(
                TipoForma.Rectangulo,
                new List<decimal>() { ancho, ancho, altura, altura },
                altura
            ) {}

        public decimal CalcularArea() => base.Lados[0] * base.Lados[2];
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;


namespace DevelopmentChallenge.Data.Classes.Figuras
{
    public class Cuadrado : FormaGeometrica, IFormaGeometrica 
    {
        public Cuadrado(decimal ancho) :
            base(
                TipoForma.Cuadrado,
                new List<decimal>() { ancho, ancho, ancho, ancho }
            ) {}

        public decimal CalcularArea() => base.Lados[0] * base.Lados[0];
    }
}

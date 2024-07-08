using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;


namespace DevelopmentChallenge.Data.Classes.Figuras
{
    public class Circulo : FormaGeometrica, IFormaGeometrica 
    {
        public Circulo(decimal diametro) : base(TipoForma.Circulo, diametro) { }

        public decimal CalcularArea() => (decimal)Math.PI * (base.Lados[0] / 2) * (base.Lados[0] / 2);
    }
}

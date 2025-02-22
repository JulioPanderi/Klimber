﻿using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IFormaGeometrica
    {
        TipoForma Forma { get; }
        decimal Apotema { get; }
        List<decimal> Lados { get; }
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}

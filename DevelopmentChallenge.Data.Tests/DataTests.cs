using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Figuras;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using NUnit.Framework;
using System.Diagnostics;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            string expected = "<h1>Lista vacía de formas!</h1>";
            string result = formas.Imprimir(Idioma.Castellano);

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            string expected = "<h1>Empty list of shapes!</h1>";

            Assert.AreEqual(expected, formas.Imprimir(Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnFrances()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            string expected = "<h1>Liste vide de Formes!</h1>";

            Assert.AreEqual(expected, formas.Imprimir(Idioma.Frances));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>() { new Cuadrado(5) };
            string result = formas.Imprimir(Idioma.Castellano);
            string expected = "<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Formas Perímetro 20 Área 25";

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            string result = formas.Imprimir(Idioma.Ingles);
            string expected = "<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35";

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnFrances()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            string result = formas.Imprimir(Idioma.Frances);
            string expected = "<h1>Rapport de Formes</h1>3 Carrés | Aire 35 | Périmètre 36 <br/>TOTAL:<br/>3 Formes Périmètre 36 Aire 35";

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>() { new TrianguloEquilatero(5) };
            string result = formas.Imprimir(Idioma.Castellano);
            string expected = "<h1>Reporte de Formas</h1>1 Triángulo | Área 10.83 | Perímetro 15 <br/>TOTAL:<br/>1 Formas Perímetro 15 Área 10.83";

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestResumenListaConMasTriangulos()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new TrianguloEquilatero(5),
                new TrianguloEquilatero(7),
                new TrianguloEquilatero(9)
            };
            string result = formas.Imprimir(Idioma.Ingles);
            string expected = "<h1>Shapes report</h1>3 Triangles | Area 67.12 | Perimeter 63 <br/>TOTAL:<br/>3 Shapes Perimeter 63 Area 67.12";

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>() { new Trapecio(5, 10, 3) };
            string result = formas.Imprimir(Idioma.Castellano);
            string expected = "<h1>Reporte de Formas</h1>1 Trapecio | Área 22.5 | Perímetro 30 <br/>TOTAL:<br/>1 Formas Perímetro 30 Área 22.5";

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>
            {
                new Trapecio(5, 10, 3),
                new Trapecio(7, 12, 5),
                new Trapecio(9, 5, 1)
            };
            string result = formas.Imprimir(Idioma.Ingles);
            string expected = "<h1>Shapes report</h1>3 Trapeziums | Area 77 | Perimeter 96 <br/>TOTAL:<br/>3 Shapes Perimeter 96 Area 77";

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>()
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            string result = formas.Imprimir(Idioma.Ingles);
            string expected = "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>TOTAL:<br/>7 Shapes Perimeter 97.66 Area 91.65";

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>()
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            string result = formas.Imprimir(Idioma.Castellano);
            string expected = "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>3 Triángulos | Área 49.64 | Perímetro 51.6 <br/>2 Círculos | Área 13.01 | Perímetro 18.06 <br/>TOTAL:<br/>7 Formas Perímetro 97.66 Área 91.65";

            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void TestExceptionLadosConCero()
        {
            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();
            ArgumentOutOfRangeException ex = Assert.Throws<ArgumentOutOfRangeException>(() => formas.Add(new Cuadrado(0)));
            Debug.WriteLine(ex.Message);
            Assert.Multiple(() =>
            {
                Assert.That(ex.ParamName.ToUpper(), Is.EqualTo("LADOS"));
                Assert.IsTrue(ex.Message.StartsWith("Los lados de la forma deben ser mayor o igual a cero"));
            });
        }
    }
}
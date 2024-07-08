/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        protected readonly decimal _apotema;
        protected readonly TipoForma _tipoForma;
        private readonly List<decimal> _lados;

        #region Constructores

        protected FormaGeometrica(TipoForma tipoForma, decimal lado)
        {
            if (lado > 0)
            {
                _tipoForma = tipoForma;
                _lados = new List<decimal>() { lado };
                _apotema = 0;
            }
            else
            {
                throw new ArgumentOutOfRangeException("lado", "El diametro debe ser mayor a cero");
            }
        }

        protected FormaGeometrica(TipoForma tipoForma, List<decimal> lados) : this(tipoForma, lados, 0) { }

        protected FormaGeometrica(TipoForma tipoForma, List<decimal> lados, decimal apotema)
        {
            if (!lados.Any())
            {
                throw new ArgumentOutOfRangeException("lados", "La forma debe tener por lo menos un lado");
            }
            if (!lados.Exists(lado => lado > 0))
            {
                throw new ArgumentOutOfRangeException("lados", "Los lados de la forma deben ser mayor o igual a cero");
            }
            _tipoForma = tipoForma;
            _lados = lados;
            _apotema = apotema;
        }

        #endregion

        #region Propiedades

        public TipoForma Forma
        {
            get => _tipoForma;
        }

        public decimal Apotema
        {
            get => _apotema;
        }

        public List<decimal> Lados
        {
            get => _lados;
        }

        #endregion

        public decimal CalcularPerimetro() => _lados.Count > 1 ? _lados.Sum() : (decimal)Math.PI * _lados[0];
    }
}

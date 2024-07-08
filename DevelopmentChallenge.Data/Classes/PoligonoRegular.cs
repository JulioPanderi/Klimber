using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class PoligonoRegular
    {
        protected readonly TipoForma _tipoForma;
        protected decimal _apotema;
        private readonly List<decimal> _lados;

        #region Constructores

        protected PoligonoRegular(TipoForma tipoForma, decimal lado)
        {
            if (lado > 0)
            {
                _tipoForma = tipoForma;
                _lados = new List<decimal>() { lado };
                _altura = 0;
            }
            else
            {
                throw new ArgumentOutOfRangeException("lado", "El diametro debe ser mayor a cero");
            }
        }

        protected PoligonoRegular(TipoForma tipoForma, List<decimal> lados) : this(tipoForma, lados, 0) { }

        protected PoligonoRegular(TipoForma tipoForma, List<decimal> lados, decimal apotema)
        {
            if (!lados.Any())
            {
                throw new ArgumentOutOfRangeException("lados", "La forma debe tener por lo menos un lado");
            }
            if (!lados.Exists(lado => lado > 0))
            {
                throw new ArgumentOutOfRangeException("lados", "Los lados de la forma deben ser mayor o igual a cero");
            }
            if (apotema <= 0)
            {
                throw new ArgumentOutOfRangeException("lados", "La apotema debe ser mayor a cero");
            }
            _tipoForma = tipoForma;
            _lados = lados;
            _apotema = apotema;
        }

        #endregion
    }
}

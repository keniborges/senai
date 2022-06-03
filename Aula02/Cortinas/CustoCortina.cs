using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula02.Cortinas
{
    public class CustoCortina
    {

        private List<Cortina> cortinas = new List<Cortina>();

        public CustoCortina()
        {
            cortinas.Add(new Cortina() { Tipo = TipoCortina.Persiana, ValorM2 = 15.20m });
            cortinas.Add(new Cortina() { Tipo = TipoCortina.Rolo, ValorM2 = 16.70m });
            cortinas.Add(new Cortina() { Tipo = TipoCortina.Romana, ValorM2 = 25.30m });
            cortinas.Add(new Cortina() { Tipo = TipoCortina.Voal, ValorM2 = 18.20m });
        }

        public decimal CalcularCusto(TipoCortina tipo, int metrosUtilizados)
        {
            var valorPorTipoCortina = cortinas.First(c => c.Tipo == tipo).ValorM2;
            return (metrosUtilizados * valorPorTipoCortina);            
        }
    }
}

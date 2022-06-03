using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Calculadoras
{
    public class Calculadora
    {
        public decimal Adicionar(decimal valorA, decimal valorB)
        {
            return valorA + valorB;
        }

        public decimal Subtrair(decimal valorA, decimal valorB)
        {
            return valorA - valorB;
        }

        public decimal Dividir(decimal valorA, decimal valorB)
        {
            return valorA / valorB;
        }

        public decimal Multiplicar(decimal valorA, decimal valorB)
        {
            return valorA * valorB;
        }
    }
}

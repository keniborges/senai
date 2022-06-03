using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.SalarioFuncionario
{
    public class Salario
    {
        public decimal Dissidio(Funcionario funcionario)
        {
            if (funcionario.Salario < 1200)
                return funcionario.Salario * 1.5m;
            else
                return funcionario.Salario * 1.3m;
        }

        public decimal CalcularBonificacao(Funcionario funcionario)
        {
            return funcionario.Salario + (funcionario.Salario * funcionario.Bonificacao);
        }
    }
}

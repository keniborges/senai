using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.SalarioFuncionario.PadraoProjeto
{
    public class Gerente : Funcionario
    {
        public override decimal Bonificacao { get; protected set; } = 0.02m;
    }
}

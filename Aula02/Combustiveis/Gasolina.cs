using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Combustiveis
{
    public class Gasolina : Combustivel
    {
        public override string Nome { get; protected set; } = "Gasolina";

        public override decimal Preco { get; protected set; } = 6.82m;

    }
}

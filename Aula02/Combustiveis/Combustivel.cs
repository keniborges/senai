using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Combustiveis
{
    public abstract class Combustivel
    {

        public abstract decimal Preco { get; protected set; }

        public virtual decimal CalcularCusto(int distantia, int media) {
            return (distantia / media) * Preco;        
        }

    }
}

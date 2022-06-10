using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Combustiveis
{
    public abstract class Combustivel
    {

        public abstract string Nome { get; protected set; }

        public abstract decimal Preco { get; protected set; }

        public virtual decimal CalcularCusto(int distancia, int media) {
            return (distancia / media) * Preco;        
        }

    }
}

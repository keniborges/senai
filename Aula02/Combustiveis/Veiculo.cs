using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Combustiveis
{
    public class Veiculo
    {
        public string Nome { get; set; }

        public int Ano { get; set; }

        public Combustivel Combustivel { get; set; }

        /// <summary>
        /// Quantos KM o veículo faz com 1 litro de combustível
        /// </summary>
        public int MediaConsumo { get; set; }


    }
}

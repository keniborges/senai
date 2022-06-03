using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula02
{
    public class Ordenar
    {

        public List<int> Ordem(List<int> numeros)
        {
            return numeros.OrderBy(c => c).ToList();
        }

        public List<string> Ordem(List<string> nomes)
        {
            return nomes.OrderBy(c => c).ToList();
        }

        public int MaiorNumero(List<int> numeros)
        {
            return numeros.Max();
        }

        public int QuantidadeCaracteres(List<string> nomes)
        {
            var quantidade = 0;
            foreach (var nome in nomes)
            {
                quantidade += nome.Length;
            }
            return quantidade;
        }

        public int SomaNumeros(List<int> numeros)
        {
            return numeros.Sum();
        }

    }
}

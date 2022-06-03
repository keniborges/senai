using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class Concatenar
    {

        public string Juntar(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
        public string Juntar2(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        public string Juntar3(string nome, string sobrenome)
        {
            var retorno = new StringBuilder();
            retorno.Append(nome).Append(" ").Append(sobrenome);
            return retorno.ToString();
        }


    }
}

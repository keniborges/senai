using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Alunos
{
    public class InformacoesAlunos
    {

        public double IdadeMedia(List<Aluno> alunos)
        {
            double idades = 0;
            foreach (var aluno in alunos)
            {
                var idade = (DateTime.Now.Year - aluno.Nascimento.Year);
                if (DateTime.Now.Month < aluno.Nascimento.Month || (DateTime.Now.Month >= aluno.Nascimento.Month && DateTime.Now.Day < aluno.Nascimento.Day))
                    idade = idade - 1;
                idades += idade;
            }
            return idades / alunos.Count;

        }

    }
}

using System.Collections.Generic;

namespace Aula03.Entidades
{
    public class Professor
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public long EscolaId { get; set; }
        public Escola Escola { get; set; }

        public List<Aluno> Alunos { get; set; }






    }
}

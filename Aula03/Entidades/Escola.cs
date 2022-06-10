using System.Collections.Generic;

namespace Aula03.Entidades
{
    public class Escola
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public List<Professor> Professores { get; set; }

    }
}

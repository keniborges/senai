using Escola.Entidades.Enums;
using System.Collections.Generic;

namespace Escola.Entidades
{
    public class Turma : Entity
    {
        public string Nome { get; set; }

        public Serie Serie { get; set; }

        public Turno Turno { get; set; }

        public long ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public List<Aluno> Alunos { get; set; }
    }
}

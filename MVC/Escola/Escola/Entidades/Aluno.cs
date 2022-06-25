using Escola.Entidades.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Escola.Entidades
{
    public class Aluno : Entity
    {
        [Required, MaxLength(80)]
        public string Nome { get; set; }

        [Required, MaxLength(80)]
        public string Sobrenome { get; set; }

        public DateTime? Nascimento { get; set; }

        [Required]
        public Sexo Sexo { get; set; }

        public long TurmaId { get; set; }
        public Turma Turma { get; set; }
    }
}

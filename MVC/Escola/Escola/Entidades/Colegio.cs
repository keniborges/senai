using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Escola.Entidades
{
    public class Colegio : Entity
    {
        [Required, MaxLength(80)]
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        public List<Professor> Professores { get; set; }
    }
}

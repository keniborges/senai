using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aula03.Entidades
{
    public class Escola : BaseEntity
    {
        [MaxLength(60), Required]
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        public List<Professor> Professores { get; set; }

        public List<Classe> Classes { get; set; }

    }
}

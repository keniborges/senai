using System.ComponentModel.DataAnnotations;

namespace Escola.Entidades
{
    public class Professor : Entity
    {
        [Required, MaxLength(80)]
        public string Nome { get; set; }

        public long ColegioId {get;set;}
        public Colegio Colegio { get; set; }

        public Turma Turma { get; set; }
    }
}

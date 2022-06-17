using System.ComponentModel.DataAnnotations;

namespace Aula03.Entidades
{
    public class Professor : BaseEntity
    {
        [MaxLength(60), Required]
        public string Nome { get; set; }

        public long EscolaId { get; set; }
        public Escola Escola { get; set; }


    }
}

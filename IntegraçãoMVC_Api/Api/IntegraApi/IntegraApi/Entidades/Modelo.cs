using System.ComponentModel.DataAnnotations;

namespace IntegraApi.Entidades
{
    public class Modelo : Entity
    {
        [Required]
        public string Nome { get; set; }

        public long MarcaId { get; set; }
        public Marca Marca { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace IntegraApi.Entidades
{
    public class Marca : Entity
    {
        [Required]
        public string Nome { get; set; }

    }
}

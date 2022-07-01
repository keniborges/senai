using System.ComponentModel.DataAnnotations;

namespace Escola.Models
{
    public class ColegioModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Campo Nome da Escola é Obrigatório")]
        public string Nome { get; set; }

        public string Rua { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }

        [MaxLength(2, ErrorMessage = "Campo Pode ter no máximo 2 dígitos")]
        public string Estado { get; set; }

        public string Cidade { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Escola.Entidades
{
    public class Endereco : Entity
    {
        [MaxLength(80)]
        public string Rua { get; set; }

        [MaxLength(80)]
        public string Bairro { get; set; }

        public int Numero { get; set; }

        [MaxLength(2)]
        public string Estado { get; set; }

        [MaxLength(80)]
        public string Cidade { get; set; }

        public long ColegioId { get; set; }
        public Colegio Colegio { get; set; }
    }
}

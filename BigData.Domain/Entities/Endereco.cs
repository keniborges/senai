namespace BigData.Domain.Entities
{
    public class Endereco : BaseEntity
    {

        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public long PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }

    }
}

namespace BigData.Domain.Entities
{
    public class Endereco : BaseEntity
    {

        public string Rua { get; set; }

        public long PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }

    }
}

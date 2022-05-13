namespace BigData.Domain.Entities
{
    public class Telefone : BaseEntity
    {
        public string NumeroFone { get; set; }

        public long PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}

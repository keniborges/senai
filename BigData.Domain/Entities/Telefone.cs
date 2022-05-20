using BigData.Domain.Enum;

namespace BigData.Domain.Entities
{
    public class Telefone : BaseEntity
    {
        public string Numero { get; set; }

        public TipoFoneEnum TipoFone {get;set;}

        public long PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}

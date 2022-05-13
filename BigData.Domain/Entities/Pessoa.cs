using BigData.Domain.Enum;
using System.Collections.Generic;

namespace BigData.Domain.Entities
{
    public class Pessoa : BaseEntity
    {
        public string Nome { get; set; }

        public string InscricaoFederal { get; set; }

        public TipoPessoa TipoPessoa { get; set; }

        public Endereco Endereco { get; set; }

        public List<Telefone> Telefones { get; set; }

    }
}

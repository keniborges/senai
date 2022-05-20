using BigData.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BigData.Domain.Entities
{
    public class Pessoa : BaseEntity
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; }

        [Required, MaxLength(14)]
        public string Cpf { get; set; }

        [Required]
        public SexoEnum Sexo { get; set; }

        public DateTime? Nascimento { get; set; }

        /// <summary>
        /// Adicionar depois
        /// </summary>
        public DateTime DataInsercao { get; set; }

        public Endereco Endereco { get; set; }

        public List<Telefone> Telefones { get; set; }

    }
}

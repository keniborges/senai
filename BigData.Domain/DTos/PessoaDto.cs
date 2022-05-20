using BigData.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BigData.Domain.DTos
{
    public class PessoaDto
    {

        //[Required, MaxLength(60)]
        public string Nome { get; set; }

        //[Required]
        //[StringLength(14, ErrorMessage = "Campo Cpf deve conter somente 14 dígitos")]
        public string Cpf { get; set; }

        //[Required]
        public SexoEnum Sexo { get; set; }

        public DateTime? Nascimento { get; set; }

        public EnderecoDto Endereco { get; set; }

        public List<TelefoneDto> Telefones { get; set; }


    }
}

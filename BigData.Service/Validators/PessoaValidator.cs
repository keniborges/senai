using BigData.Domain.DTos;
using FluentValidation;
using BigData.Service.Helpers;

namespace BigData.Service.Validators
{
    public class PessoaValidator : AbstractValidator<PessoaDto>
    {
        public PessoaValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(60).WithMessage("Campo Nome deve conter no máximo 60 caracteres");
            RuleFor(x => x.Cpf).NotEmpty().MaximumLength(14).WithMessage("Cpf deve conter no máximo 14 caracteres.");
            RuleFor(x => x.Cpf).Must(CpfValido).WithMessage("CPF Inválido");
        }

        private bool CpfValido(string cpf)
        {
            return (cpf.IsCpf() ? true : false);
        }

    }
}

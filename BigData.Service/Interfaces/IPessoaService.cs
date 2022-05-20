using BigData.Domain.DTos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigData.Service.Interfaces
{
    public interface IPessoaService
    {
        void BuscarPessoaPorCpf(string cpf);

        Task<bool> SalvarPessoa(PessoaDto model);
    }
}

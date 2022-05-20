using BigData.Domain.Entities;
using System.Threading.Tasks;

namespace BigData.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        void BuscarPessoa(string cnpj);

        Task Salvar(Pessoa entity);
    }
}

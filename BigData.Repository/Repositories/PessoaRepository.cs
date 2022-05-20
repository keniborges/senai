using BigData.Domain.Entities;
using BigData.Domain.Interfaces;
using BigData.Repository.Context;
using System.Threading.Tasks;

namespace BigData.Repository.Repositories
{
    public class PessoaRepository : GenericRepository<Pessoa>, IPessoaRepository
    {

        public PessoaRepository(BigDataContext context) : base(context)
        {

        }

        public async Task Salvar(Pessoa entity)
        {
            await SaveAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void BuscarPessoa(string cnpj)
        {
            
        }


    }
}

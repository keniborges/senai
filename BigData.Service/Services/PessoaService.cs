using AutoMapper;
using BigData.Domain.DTos;
using BigData.Domain.Entities;
using BigData.Domain.Interfaces;
using BigData.Service.Interfaces;
using System.Threading.Tasks;

namespace BigData.Service.Services
{
    public class PessoaService : IPessoaService
    {

        private readonly IMapper _mapper;
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository, IMapper mapper)
        {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }

        public void BuscarPessoaPorCpf(string cpf)
        {
            _pessoaRepository.BuscarPessoa(cpf);            
        }

        public async Task<bool> SalvarPessoa(PessoaDto model)
        {
            try
            {
                var pessoa = _mapper.Map<Pessoa>(model);
                await _pessoaRepository.Salvar(pessoa);
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}

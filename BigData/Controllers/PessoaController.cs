using BigData.Domain.DTos;
using BigData.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BigData.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PessoaController
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        [Route("buscar-pessoa")]
        public IActionResult Get([FromQuery] string cpf)
        {
            _pessoaService.BuscarPessoaPorCpf(cpf);
            return new JsonResult(null);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PessoaDto model)
        {
            var resultado = await _pessoaService.SalvarPessoa(model);
            return new JsonResult(resultado);
        }

        [HttpPut]
        public IActionResult Put()
        {
            return new JsonResult(null);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return new JsonResult(null);
        }

    }
}

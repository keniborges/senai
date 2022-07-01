using Escola.Entidades;
using Escola.Models;
using Escola.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Escola.Controllers
{
    public class ColegioController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IColegioRepository _colegioRepository;


        public ColegioController(ILogger<HomeController> logger, IColegioRepository colegioRepository)
        {
            _logger = logger;
            _colegioRepository = colegioRepository;

        }

        public IActionResult Index()
        {
            ViewData["colegios"] = _colegioRepository.BuscarTodos();
            return View();
        }

        public IActionResult Nova()
        {
            var model = new ColegioModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Nova(ColegioModel model)
        {
            if (ModelState.IsValid)
            {
                var colegio = new Colegio()
                {
                    Nome = model.Nome,
                    Endereco = new Endereco()
                    {
                        Id = model.Id,
                        Rua = model.Rua,
                        Bairro = model.Bairro,
                        Numero = model.Numero,
                        Estado = model.Estado,
                        Cidade = model.Cidade
                    }
                };
                var retorno = _colegioRepository.Salvar(colegio);
                return RedirectToAction("Index", "Colegio");
            }
            return View(model);
        }

        public IActionResult Editar(long id)
        {
            var colegio = _colegioRepository.BuscarPorId(id);
            var model = new ColegioModel()
            {
                Id = colegio.Id,
                Nome = colegio.Nome,
                Bairro = colegio.Endereco.Bairro,
                Cidade = colegio.Endereco.Cidade,
                Rua = colegio.Endereco.Rua,
                Numero = colegio.Endereco.Numero,
                Estado = colegio.Endereco.Estado
            };

            return View("Nova", model);
        }

        public IActionResult Excluir(long id)
        {
            try
            {
                var colegio = _colegioRepository.BuscarPorId(id);
                _colegioRepository.Excluir(colegio);
                return Json(true);
            }
            catch
            {
                return Json(false);
            }            
        }



    }
}

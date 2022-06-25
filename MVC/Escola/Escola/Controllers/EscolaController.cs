using Escola.Entidades;
using Escola.Models;
using Escola.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Controllers
{
    public class EscolaController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IColegioRepository _colegioRepository;


        public EscolaController(ILogger<HomeController> logger, IColegioRepository colegioRepository)
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
            var model = new EscolaModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Nova(EscolaModel model)
        {
            if (ModelState.IsValid)
            {
                var colegio = new Colegio()
                {
                    Nome = model.Nome,
                    Endereco = new Endereco()
                    {
                        Rua = model.Rua,
                        Bairro = model.Bairro,
                        Numero = model.Numero,
                        Estado = model.Estado,
                        Cidade = model.Cidade
                    }
                };
                var retorno = _colegioRepository.Salvar(colegio);
                return RedirectToAction("Index", "Escola");
            }
            return View(model);
        }



    }
}

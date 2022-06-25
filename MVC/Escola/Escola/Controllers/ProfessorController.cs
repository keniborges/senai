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
    public class ProfessorController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IColegioRepository _colegioRepository;
        private readonly IProfessorRepository _professorRepository;


        public ProfessorController(ILogger<HomeController> logger, IColegioRepository colegioRepository, IProfessorRepository professorRepository)
        {
            _logger = logger;
            _colegioRepository = colegioRepository;
            _professorRepository = professorRepository;

        }

        public IActionResult Index()
        {
            ViewData["professores"] = _professorRepository.BuscarTodos();
            return View();
        }

        public IActionResult Nova()
        {
            var model = new ProfessorModel();
            ViewData["colegios"] = _colegioRepository.BuscarTodos();
            return View(model);
        }

        [HttpPost]
        public IActionResult Nova(ProfessorModel model)
        {
            if (ModelState.IsValid)
            {
                var professor = new Professor()
                {
                    Nome = model.Nome,
                    ColegioId = model.ColegioId
                };
                var retorno = _professorRepository.Salvar(professor);
                return RedirectToAction("Index", "Professor");
            }
            return View(model);
        }



    }
}

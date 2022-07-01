using Escola.Entidades;
using Escola.Models;
using Escola.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Linq;

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

        private void IncludeViewBagColegios()
        {
            ViewBag.Colegios = _colegioRepository.BuscarTodos().Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() }).ToList();
        }

        public IActionResult Index()
        {
            ViewData["professores"] = _professorRepository.BuscarTodos();
            return View();
        }

        public IActionResult Nova()
        {
            var model = new ProfessorModel();
            IncludeViewBagColegios();
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
            IncludeViewBagColegios();
            return View(model);
        }

        public IActionResult Editar(long id)
        {
            var professor = _professorRepository.BuscarPorId(id);
            var model = new ProfessorModel()
            {
                Id = professor.Id,
                Nome = professor.Nome,
                ColegioId = professor.ColegioId
            };
            IncludeViewBagColegios();
            return View("Nova", model);
        }

        public IActionResult Excluir(long id)
        {
            try
            {
                var professor = _professorRepository.BuscarPorId(id);
                _professorRepository.Excluir(professor);
                return Json(true);
            }
            catch
            {
                return Json(false);
            }
        }

    }
}

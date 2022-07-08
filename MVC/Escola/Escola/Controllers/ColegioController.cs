using Escola.Entidades;
using Escola.Models;
using Escola.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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

        private List<SelectListItem> Estados()
        {
            var estados = new List<SelectListItem>() {
                new SelectListItem(){ Value = "Acre", Text = "AC" },
                new SelectListItem(){ Value = "Alagoas", Text = "AL" },
                new SelectListItem(){ Value = "Amapá", Text = "AP" },
                new SelectListItem(){ Value = "Amazonas", Text = "AM" },
                new SelectListItem(){ Value = "Bahia", Text = "BA" },
                new SelectListItem(){ Value = "Ceará", Text = "CE" },
                new SelectListItem(){ Value = "Distrito Federal", Text = "DF" },
                new SelectListItem(){ Value = "Espírito Santo", Text = "ES" },
                new SelectListItem(){ Value = "Goiás", Text = "GO" },
                new SelectListItem(){ Value = "Maranhão", Text = "MA" },
                new SelectListItem(){ Value = "Mato Grosso", Text = "MT" },
                new SelectListItem(){ Value = "Mato Grosso do Sul", Text = "MS" },
                new SelectListItem(){ Value = "Minas Gerais", Text = "MG" },
                new SelectListItem(){ Value = "Pará", Text = "PA" },
                new SelectListItem(){ Value = "Paraíba", Text = "PB" },
                new SelectListItem(){ Value = "Paraná", Text = "PR" },
                new SelectListItem(){ Value = "Pernambuco", Text = "PE" },
                new SelectListItem(){ Value = "Piauí", Text = "PI" },
                new SelectListItem(){ Value = "Rio de Janeiro", Text = "RJ" },
                new SelectListItem(){ Value = "Rio Grande do Norte", Text = "RN" },
                new SelectListItem(){ Value = "Rio Grande do Sul", Text = "RS" },
                new SelectListItem(){ Value = "Rondônia", Text = "RO" },
                new SelectListItem(){ Value = "Roraima", Text = "RR" },
                new SelectListItem(){ Value = "Santa Catarina", Text = "SC" },
                new SelectListItem(){ Value = "São Paulo", Text = "SP" },
                new SelectListItem(){ Value = "Sergipe", Text = "SE" },
                new SelectListItem(){ Value = "Tocantins", Text = "TO" }
            };
            return estados;
        }

        public IActionResult Index()
        {
            ViewData["colegios"] = _colegioRepository.BuscarTodos();
            return View();
        }

        public IActionResult Nova()
        {
            var model = new ColegioModel();
            ViewBag.Estados = Estados();
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
            ViewBag.Estados = Estados();
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

using IntegraApi.Entidades;
using IntegraApi.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculosController : ControllerBase
    {

        private readonly IMarcaRepository _marcaRepository;
        private readonly IModeloRepository _modeloRepository;

        public VeiculosController(IMarcaRepository marcaRepository, IModeloRepository modeloRepository)
        {
            _marcaRepository = marcaRepository;
            _modeloRepository = modeloRepository;
        }

        [HttpPost]
        [Route("inserir-marca")]
        public bool InserirMarca([FromBody] Marca marca)
        {
            try
            {
                return _marcaRepository.Salvar(marca);
            }
            catch
            {
                return false;
            }
            
        }

        [HttpPost]
        [Route("inserir-modelo")]
        public bool InserirModelo([FromBody] Modelo modelo)
        {
            try
            {
                return _modeloRepository.Salvar(modelo);
            }
            catch
            {
                return false;
            }

        }

        [HttpGet]
        [Route("pegar-marcas")]
        public IEnumerable<Marca> PegarMarcas()
        {
            return _marcaRepository.BuscarTodos();
        }

        private IEnumerable<Modelo> Modelos()
        {
            var modelos = new List<Modelo>();
            modelos.Add(new Modelo() { Id = 1, Nome = "Punto", MarcaId = 1 });
            modelos.Add(new Modelo() { Id = 2, Nome = "Uno", MarcaId =  1});
            modelos.Add(new Modelo() { Id = 3, Nome = "Fiesta", MarcaId = 2 });
            modelos.Add(new Modelo() { Id = 4, Nome = "Ka", MarcaId = 2 });
            modelos.Add(new Modelo() { Id = 5, Nome = "Gol", MarcaId = 3 });
            modelos.Add(new Modelo() { Id = 6, Nome = "Polo", MarcaId = 3 });
            modelos.Add(new Modelo() { Id = 7, Nome = "Cruze", MarcaId = 4 });
            modelos.Add(new Modelo() { Id = 8, Nome = "Onix", MarcaId = 4 });
            modelos.Add(new Modelo() { Id = 9, Nome = "Civic", MarcaId = 5 });
            modelos.Add(new Modelo() { Id = 10, Nome = "HR-V", MarcaId = 5 });
            modelos.Add(new Modelo() { Id = 11, Nome = "Corolla", MarcaId = 6 });
            modelos.Add(new Modelo() { Id = 12, Nome = "Yaris", MarcaId = 6 });

            return modelos;
        }

        [HttpGet]
        [Route("pegar-modelos")]
        public IEnumerable<Modelo> PegarModelos(long marcaId)
        {
            return _modeloRepository.BuscarPorMarcaId(marcaId);
        }


    }
}

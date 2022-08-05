using IntegraApi.Entidades;
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


        [HttpGet]
        [Route("pegar-marcas")]
        public IEnumerable<Marca> PegarMarcas()
        {
            var marcas = new List<Marca>();
            marcas.Add(new Marca() { Id = 1, Nome = "Fiat" });
            marcas.Add(new Marca() { Id = 2, Nome = "Ford" });
            marcas.Add(new Marca() { Id = 3, Nome = "Volkswagem" });
            marcas.Add(new Marca() { Id = 4, Nome = "Chevrolet" });
            marcas.Add(new Marca() { Id = 5, Nome = "Honda" });
            marcas.Add(new Marca() { Id = 6, Nome = "Toyota" });

            return marcas;
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
            var modelos = Modelos().Where(c => c.MarcaId == marcaId).ToList();
            return modelos;
        }



    }
}

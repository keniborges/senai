using IntegraMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using RestSharp;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IntegraMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private IEnumerable<MarcaModel> PegarMarcas()
        {
            var client = new RestClient("https://localhost:44376/");
            var request = new RestRequest("/Veiculos/pegar-marcas", Method.Get);
            return client.Execute<List<MarcaModel>>(request).Data;
        }

        private IEnumerable<ModeloModel> PegarModelos(long marcaId)
        {
            var client = new RestClient("https://localhost:44376/");
            var request = new RestRequest("/Veiculos/pegar-modelos", Method.Get);
            request.AddParameter("marcaId", marcaId);
            return client.Execute<List<ModeloModel>>(request).Data;
        }

        private IEnumerable<SelectListItem> Marcas()
        {
            var marcas = PegarMarcas().Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() });
            return marcas;
        }
            

        public IActionResult Index()
        {
            ViewBag.Marcas = Marcas();
            return View();
        }

        public IEnumerable<ModeloModel> BuscarModelos(long marcaId)
        {
            return PegarModelos(marcaId);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

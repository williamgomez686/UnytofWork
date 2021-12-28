using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UnidadTrabajo.bussisnesLayer;
using UnidadTrabajo.Models;

namespace UnidadTrabajo.Controllers
{
    public class PDFController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PDFController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult listar()
        {
            List<FacturaViewModel> oVer = servicos.Intancia.Listar();
            return View(oVer);
        }

        public IActionResult Todos()
        {
            var todos = new FacturaServicios();
            var resultado = todos.GetAll();
            return View(resultado);
        }

        public IActionResult unaFactura()
        {
            var factura = new FacturaServicios();
            var rsultado = factura.verFactura(128241);
            return View(rsultado);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

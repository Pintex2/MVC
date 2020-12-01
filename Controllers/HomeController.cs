using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var coches = new List<Coche>
            {
                new Coche {Marca="BMW",Modelo="X6",Color="Gris"},
                new Coche {Marca="Mazda",Modelo="Cx5",Color="Plomo"},
                new Coche {Marca="Mercedez",Modelo="Amg",Color="Blanco"},
                new Coche {Marca="Toyota",Modelo="Rav4",Color="Negro"},
            };
            return View(coches);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

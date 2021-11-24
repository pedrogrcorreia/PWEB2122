using Ex3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3.Controllers
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
            UnidadeCurricular uc = new UnidadeCurricular();
            uc.ECTS = 6;
            uc.Semestre = 5;
            uc.Nome = "PWEB";
            uc.Curso = "Eng. Informática";
            return View(uc);
        }

        public IActionResult Index2()
        {
            UnidadeCurricular uc = new UnidadeCurricular();
            uc.ECTS = 6;
            uc.Semestre = 5;
            uc.Nome = "PWEB";
            uc.Curso = "Eng. Informática";
            return View(uc);
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

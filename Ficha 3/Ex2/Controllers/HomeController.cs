using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            ViewBag.Nome = "PWEB";
            ViewBag.ECTS = 6;
            ViewBag.Curso = "Eng Inf";
            ViewBag.Semestre = 10;
            return View();
        }
    }
}

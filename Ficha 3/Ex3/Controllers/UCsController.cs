using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex3.Models;

namespace Ex3.Controllers
{
    public class UCsController : Controller
    {

        private List<UnidadeCurricular> ucs = new List<UnidadeCurricular> {
            new UnidadeCurricular {
                Nome="Programação Web",
                ECTS=6,
                Curso="Engenharia Informática",
                Semestre= 5
            },
            new UnidadeCurricular {
                Nome="Arquiteturas Móveis",
                ECTS=6,
                Curso="Engenharia Informática",
                Semestre=5
            },
            new UnidadeCurricular {
                Nome="Programação Distribuída",
                ECTS=6,
                Curso="Engenharia Informática",
                Semestre=5
            },
            new UnidadeCurricular {
                Nome="Inteligência Computacional",
                ECTS=6,
                Curso="Engenharia Informática",
                Semestre=5
            }
        };


        public IActionResult Index()
        {
            return View(ucs);
        }

        public IActionResult Index2()
        {
            return View(ucs);
        }
    }
}

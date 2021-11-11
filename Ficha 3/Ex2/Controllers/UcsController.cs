using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2.Controllers
{
    public class UcsController : Controller
    {
        private List<string> ListaUCs = new List<string> {
            "Estratégia Organizacional",
            "Arquiteturas Móveis",
            "Programação Distribuída",
            "Inteligência Computacional"
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            //ViewBag.UCs = ListaUCs; // passagem por viewbag
            return View("Teste", ListaUCs); // passar por modelo acrescenta-se ao segundo parametro
        }
    }
}

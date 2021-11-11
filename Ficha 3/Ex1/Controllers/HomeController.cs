using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult Index()
        {
            string html = "<ul>"+
                            "<li>Nome: PWEB </li>"+
                            "<li>ECTS: 6 </li>" +
                            "<li>Curso: Eng Inf.</li>" +
                            "<li>Semestre: 5 </li>" +
                          "</ul>";
            return Content(html, "text/html", System.Text.Encoding.UTF8);
        }
    }
}

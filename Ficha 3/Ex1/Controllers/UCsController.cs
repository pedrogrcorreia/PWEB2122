using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Controllers
{
    public class UCsController : Controller
    {
        public IActionResult Index()
        {
            string html = "<ul>" +
                            "<li>GPS</li>" +
                            "<li>Arq M</li>" +
                            "<li>PD</li>" +
                            "<li>ED</li>" +
                          "</ul>";
            return Content(html, "text/html", System.Text.Encoding.UTF8);
        }
    }
}

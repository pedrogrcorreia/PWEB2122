using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ficha4.AppCode;
using Ficha4.AppData;
using Ficha4.Models;
using Ficha4.ViewModels;

namespace Ficha4.Controllers
{
    public class ConverteMoedasController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.UnidadesMonetarias = ConverteAppCode.SelectListItem_UnidadesMonetarias2(
                ConverteMockData.UnidadesMonetarias);

            return View();
        }

        [HttpPost]
        public ActionResult Index(ConverteDataViewModel model)
        {
            ViewBag.UnidadesMonetarias = ConverteAppCode.SelectListItem_UnidadesMonetarias2(
                ConverteMockData.UnidadesMonetarias);

            var modelo = new ConverteData();
            modelo.UnidadeInicial = model.UnidadeInicial;
            modelo.UnidadeFinal = model.UnidadeFinal;

            model.ValorInicial = model.ValorInicial.Replace('.', ',');
            double vpe;

            if (double.TryParse(model.ValorInicial, out vpe))
            {
                modelo.ValorInicial = vpe;
                modelo.ConvertData(ConverteMockData.UnidadesMonetarias);
            }
            else
            {
                ModelState.AddModelError("ValorInicial", "Valor Inicial inserido é inválido.");
            }

            return View(modelo);
        }
    }
}

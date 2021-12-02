using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ficha4.AppData;
using Ficha4.Models;

namespace Ficha4.Controllers
{
    public class UnidadesMonetariasController : Controller
    {
        // GET: UnidadeMonetariasController
        public ActionResult Index()
        {
            return View(ConverteMockData.UnidadesMonetarias);
        }

        // GET: UnidadeMonetariasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnidadeMonetariasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                UnidadeMonetaria unidade = new UnidadeMonetaria();

                unidade.Data = DateTime.Now;
                string codigo = collection["Codigo"];
                codigo = codigo.Trim();

                //Evitar codigos repetidos
                if (ConverteMockData.UnidadesMonetarias.Select(x => x.Codigo).Contains(codigo))
                {
                    ModelState.AddModelError("Codigo", "Já existe um código com esse valor.");
                    return View(unidade);
                }

                string valor = collection["ValorPorEuro"];
                valor = valor.Replace('.', ',');
                double vpe;

                if (double.TryParse(valor, out vpe))
                {
                    unidade.Id = ConverteMockData.NewId;
                    unidade.Codigo = codigo;
                    unidade.ValorPorEuro = vpe;

                    ConverteMockData.UnidadesMonetarias.Add(unidade);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "Valor / Euro inserido é inválido.");
                    return View(unidade);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: UnidadeMonetariasController/Edit/5
        public ActionResult Edit(int id)
        {
            var unidade = ConverteMockData.UnidadesMonetarias.Where(p => p.Id == id).FirstOrDefault();

            if (unidade == null)
                return RedirectToAction(nameof(Index));

            return View(unidade);
        }

        // POST: UnidadeMonetariasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var unidade = ConverteMockData.UnidadesMonetarias
                                    .Where(p => p.Id == id)
                                    .FirstOrDefault();

                if (unidade == null)
                    return RedirectToAction(nameof(Index));

                //Evitar a alteração para outro código existente:
                List<UnidadeMonetaria> EstaUnidade = new List<UnidadeMonetaria>();
                EstaUnidade.Add(unidade);

                IEnumerable<UnidadeMonetaria> OutrasUnidades = ConverteMockData.UnidadesMonetarias.Except(EstaUnidade);

                string codigo = collection["Codigo"];
                codigo = codigo.Trim();

                if (OutrasUnidades.Select(x => x.Codigo).Contains(codigo))
                {
                    ModelState.AddModelError("Codigo", "Já existe uma unidade monetária com esse código.");
                    return View(unidade);
                }

                // Continue:
                string valor = collection["ValorPorEuro"];
                valor = valor.Replace('.', ',');
                double vpe;

                if (double.TryParse(valor, out vpe))
                {
                    unidade.Codigo = codigo;
                    unidade.ValorPorEuro = vpe;
                    unidade.Data = DateTime.Now;
                }
                else
                {
                    ModelState.AddModelError("ValorPorEuro", "Valor / Euro inserido é inválido.");
                    return View(unidade);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UnidadeMonetariasController/Delete/5
        public ActionResult Delete(int id)
        {
            var unidade = ConverteMockData.UnidadesMonetarias.Where(p => p.Id == id).FirstOrDefault();

            if (unidade == null)
                return RedirectToAction(nameof(Index));

            return View(unidade);
        }

        // POST: UnidadeMonetariasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var unidade = ConverteMockData.UnidadesMonetarias.Where(p => p.Id == id).FirstOrDefault();

                if (unidade == null)
                    return RedirectToAction(nameof(Index));

                ConverteMockData.UnidadesMonetarias.Remove(unidade);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

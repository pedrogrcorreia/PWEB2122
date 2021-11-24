using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex4.Models;

namespace Ex4.Controllers
{
    public class UCsController : Controller
    {
        // GET: UCsController
        public ActionResult Index()
        {
            return View(UCsMockData.ListaUCs);
        }

        // GET: UCsController/Details/5
        public ActionResult Details(int id)
        {
            var uc = UCsMockData.ListaUCs.Find(u => u.Id == id);

            if(uc == null)
            {
                return RedirectToAction(nameof(Index)); // volta para o index caso a uc nao exista
            }
            return View(uc);
        }

        // GET: UCsController/Create
        [HttpGet] // opcional esta tag
        public ActionResult Create()
        {
            return View();
        }

        // POST: UCsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                UC nova = new UC();
                int maxId = (from x in UCsMockData.ListaUCs select x.Id).Max();

                nova.Id = maxId + 1;
                nova.Nome = collection["Nome"];
                nova.Licenciatura = collection["Licenciatura"];
                nova.Ramo = collection["Ramo"];

                int semestre;
                int ects;
                bool error = false;

                if (int.TryParse(collection["Semestre"], out semestre))
                {
                    if (semestre > 0 && semestre < 7)
                        nova.Semestre = semestre;
                    else
                    {
                        ModelState.AddModelError("Semestre", "Semestre tem de ter um valor entre 1 e 6");
                        error = true;
                    }
                }
                else
                {
                    error = true;
                }
                if (int.TryParse(collection["ECTS"], out ects))
                {
                    if (ects > 0 && ects < 31)
                        nova.ECTS = ects;
                    else
                    {
                        ModelState.AddModelError("ECTS", "ECTS tem de ter um valor entre 1 e 30");
                        error = true;
                    }
                }
                else
                {
                    error = true;
                }

                if (error)
                {
                    ModelState.AddModelError("", "Existem erros para corrigir");
                    return View(nova);
                }

                UCsMockData.ListaUCs.Add(nova);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UCsController/Edit/5
        public ActionResult Edit(int id)
        {
            var nova = UCsMockData.ListaUCs.Find(uc => uc.Id == id);

            if (nova == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(nova);
        }

        // POST: UCsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            var nova = UCsMockData.ListaUCs.Find(uc => uc.Id == id);

            if(nova == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                
                nova.Nome = collection["Nome"];
                nova.Licenciatura = collection["Licenciatura"];
                nova.Ramo = collection["Ramo"];

                int semestre;
                int ects;
                bool error = false;

                if (int.TryParse(collection["Semestre"], out semestre))
                {
                    if (semestre > 0 && semestre < 7)
                        nova.Semestre = semestre;
                    else
                    {
                        ModelState.AddModelError("Semestre", "Semestre tem de ter um valor entre 1 e 6");
                        error = true;
                    }
                }
                else
                {
                    error = true;
                }
                if (int.TryParse(collection["ECTS"], out ects))
                {
                    if (ects > 0 && ects < 31)
                        nova.ECTS = ects;
                    else
                    {
                        ModelState.AddModelError("ECTS", "ECTS tem de ter um valor entre 1 e 30");
                        error = true;
                    }
                }
                else
                {
                    error = true;
                }

                if (error)
                {
                    ModelState.AddModelError("", "Existem erros para corrigir");
                    return View(nova);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UCsController/Delete/5
        public ActionResult Delete(int id)
        {
            var nova = UCsMockData.ListaUCs.Find(uc => uc.Id == id);

            if (nova == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(nova);
        }

        // POST: UCsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var nova = UCsMockData.ListaUCs.Find(uc => uc.Id == id);

                if (nova == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                UCsMockData.ListaUCs.Remove(nova);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

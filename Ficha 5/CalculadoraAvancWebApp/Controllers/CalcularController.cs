using Microsoft.AspNetCore.Mvc;
using CalculadoraAvancWebApp.ViewModels;
using CalculadoraAvancWebApp.AppCode;
using CalculadoraSimples;

namespace CalculadoraAvancWebApp.Controllers
{
    public class CalcularController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculadoraViewModels());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind(include: "OpDir, OpEsq, NDigitos")] CalculadoraViewModels model, string Operacao )
        {
            model.Resultado = MaquinaCalcular.Calcular(
                model.OpDir, Operadores.GetOperador(Operacao), model.OpEsq, model.NDigitos);

            return View(model);
        }
    }
}

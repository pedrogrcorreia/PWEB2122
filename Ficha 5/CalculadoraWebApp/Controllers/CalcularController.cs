using Microsoft.AspNetCore.Mvc;
using CalculadoraAvancWebApp.Models;
using CalculadoraSimples;

namespace CalculadoraAvancWebApp.Controllers
{
    public class CalcularController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculadoraModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind(include:"OpDir, OpEsq")] CalculadoraModel model, string Operacao)
        {
            model.Resultado = CalculadoraSimples.MaquinaCalcular.Calcular(
                model.OpDir, GetOperador(Operacao), model.OpEsq);
            return View(model);
        }

        private TipoOperador GetOperador(string s)
        {
            TipoOperador t = TipoOperador.divisao;
            switch (s)
            {
                case "Adição":
                    t = TipoOperador.adicao;
                        break;
                case "Subtração":
                    t = TipoOperador.subtracao;
                    break;
                case "Multiplicação":
                    t = TipoOperador.multiplicacao;
                    break;
                case "Divisão":
                    t = TipoOperador.divisao;
                    break;
            }
            return t;
        }
    }
}

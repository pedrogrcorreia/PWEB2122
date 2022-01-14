using CalculadoraSimples;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CalculadoraAvancWebApp.AppCode
{
    public static class Operadores
    {
        public static TipoOperador GetOperador(string s)
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

    public static class DigitosDecimais
    {
        public static SelectList ListaDigitosDecimais(int ndd = 6)
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            
            if(ndd <= 0)
            {
                ndd = 6;
            }

            for(int i = 0; i <= ndd; i++)
            {
                lista.Add(new SelectListItem { 
                    Value = i.ToString(), Text = $"Digitos Decimais [{i.ToString()}]" 
                });
            }

            return new SelectList(lista, "Value", "Text");
        }
    }
}

using System;

namespace CalculadoraSimples
{
    public enum TipoOperador { adicao, subtracao, multiplicacao, divisao };
    public class MaquinaCalcular
    {
        public static string Calcular(string OpEsq, TipoOperador Op, string OpDir, int NumDigDec = 2)
        {
            string resultado = String.Empty;
            string ndd = $"F{NumDigDec.ToString()}";

            if(double.TryParse(OpEsq, out double v1) && double.TryParse(OpDir, out double v2))
            {
                switch (Op)
                {
                    case TipoOperador.adicao:
                        resultado = (v1+v2).ToString(ndd);
                        break;
                    case TipoOperador.subtracao:
                        resultado = (v1 - v2).ToString(ndd);
                        break;
                    case TipoOperador.multiplicacao:
                        resultado = (v1 * v2).ToString(ndd);
                        break;
                    case TipoOperador.divisao:
                        resultado = (v2 != 0) ? (v1 / v2).ToString(ndd) : "Indefinido";
                        break;
                }
            }
            else
            {
                resultado = "Valor Incorreto";
            }
            return resultado;
        }
    }
}
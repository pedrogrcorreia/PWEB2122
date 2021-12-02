using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ficha4.Models
{
    public partial class ConverteData
    {
        public void ConvertData(List<UnidadeMonetaria> unidades_monetarias)
        {
            double taxaCambio = 0;

            double TaxaCambioEuroMoedaInicial = RatioExchange(unidades_monetarias, UnidadeInicial);
            double TaxaCambioEuroMoedaFinal = RatioExchange(unidades_monetarias, UnidadeFinal);

            if (TaxaCambioEuroMoedaInicial != 0)
                taxaCambio = TaxaCambioEuroMoedaFinal / TaxaCambioEuroMoedaInicial;

            this.ValorFinal = Convert.ToDouble((ValorInicial * taxaCambio).ToString("F3"));
            this.TaxaCambio = Convert.ToDouble(taxaCambio.ToString("F4"));
        }

        private double RatioExchange(List<UnidadeMonetaria> lum, int selopt)
        {
            double rt = 0.0;

            var unidade = lum.Where(p => p.Id == selopt).FirstOrDefault();

            if (unidade != null)
                rt = unidade.ValorPorEuro;

            return rt;
        }
    }
}

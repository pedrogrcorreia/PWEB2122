using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ficha4.Models;

namespace Ficha4.AppData
{
    public class ConverteMockData
    {
        private static List<UnidadeMonetaria> unidades_monetarias;
        private static int IDs;

        public static List<UnidadeMonetaria> UnidadesMonetarias
        {
            get
            {
                if (unidades_monetarias == null)
                    unidades_monetarias = ExchangeMockInitialData();

                return unidades_monetarias;
            }
        }

        //Devolve um novo Id
        public static int NewId
        {
            get { return ++IDs; }
        }


        static private List<UnidadeMonetaria> ExchangeMockInitialData()
        {
            List<UnidadeMonetaria> TaxasCambio = new List<UnidadeMonetaria>
            {
                new UnidadeMonetaria {Id= 1, Codigo= "[EURO] Euro", ValorPorEuro= 1.00, Data= DateTime.Now},
                new UnidadeMonetaria {Id= 2, Codigo= "[USD] Dollar USA", ValorPorEuro= 1.15, Data= DateTime.Now},
                new UnidadeMonetaria {Id= 3, Codigo= "[JPY] Yene Japan", ValorPorEuro= 130.59, Data= DateTime.Now},
                new UnidadeMonetaria {Id= 4, Codigo= "[GBP] Libra UK", ValorPorEuro= 0.86, Data= DateTime.Now},
                new UnidadeMonetaria {Id= 5, Codigo= "[CHF] Franco CH", ValorPorEuro= 1.06, Data= DateTime.Now}
                };

            IDs = 5;
            return TaxasCambio;
        }
    }
}

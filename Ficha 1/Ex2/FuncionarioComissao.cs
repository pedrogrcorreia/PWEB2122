using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha1Ex2
{
    class FuncionarioComissao
    {
        public string Nomes { get; }
        public string Apelidos { get; }
        public string NIF { get; }

        private double vendas_totais;   // valor total das vendas efectuadas

        private double comissao_vendas;  // valor da comissão ]0-1[

        public double VendasTotais
        {
            get { return vendas_totais; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(vendas_totais)} tem que ser >= 0");
                }

                vendas_totais = value;
            }
        }

        public double ComissaoVendas
        {
            get { return comissao_vendas; }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(ComissaoVendas)} tem que ser > 0 e < 1");
                }

                comissao_vendas = value;
            }
        }


        public FuncionarioComissao(
            string nomes,
            string apelidos,
            string nif,
            double vendas_totais,
            double comissao_vendas
         )
        {
            Nomes = nomes;
            Apelidos = apelidos;
            NIF = nif;
            VendasTotais = vendas_totais;                 // valida as vendas
            ComissaoVendas = comissao_vendas;             // valida a comissao
        }

        public virtual double Vencimento()
        {
            return comissao_vendas * vendas_totais;
        }

        public override string ToString()
        {
            return $"Funcionario: {Nomes} {Apelidos}\n" + $"NIF: {NIF}\n" + $"Vendas Totais: {vendas_totais:F2}\n" +
                   $"Comissao de Vendas: {comissao_vendas:F2}\n";
        }
    }
}

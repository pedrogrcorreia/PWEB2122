using System;

namespace Ficha1Ex2
{
    class FuncionarioVencBase : FuncionarioComissao
    {
        private double vencimento_base;

        public double VencimentoBase
        {
            get{ return vencimento_base; }
            
            set{
                if(value < 0){
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(vencimento_base)} tem que ser >= 0");
                }

                vencimento_base = value;
            }
        }
        public FuncionarioVencBase(
            string nomes,
            string apelidos,
            string nif,
            double vendas_totais,
            double comissao_vendas,
            double vencimento_base
         ):base(nomes, apelidos, nif, vendas_totais, comissao_vendas){
            VencimentoBase = vencimento_base; // validar o vencimento base 
         }

         public override double Vencimento(){
             return ComissaoVendas * VendasTotais + vencimento_base;
             //return base.Vencimento() + VencimentoBase; -> another implementation
         }

         public override string ToString(){
                return base.ToString() + $"Vencimento base: = {this.VencimentoBase}\n";
         }
    }
}
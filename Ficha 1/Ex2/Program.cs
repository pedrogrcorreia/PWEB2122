using System;

namespace Ficha1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcComissao = new FuncionarioComissao("Barbara", "Costa", "112121", 10000, 0.06);

            Console.WriteLine($"{funcComissao}Vencimento Final = {funcComissao.Vencimento():F2}\n");

            var funcVencBase = new FuncionarioVencBase("Pedro", "Correia", "269859756", 1000, 0.5, 300);

            Console.WriteLine($"{funcVencBase}Vencimento Final = {funcVencBase.Vencimento():F2}\n");
        }
    }
}

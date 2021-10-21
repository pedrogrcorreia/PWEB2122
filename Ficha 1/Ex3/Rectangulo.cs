using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1ex3
{
    class Retangulo: FiguraPlana
    {
        public double Comprimento { get; }
        public double Largura { get; }

        public Retangulo(double comprimento = 0, double largura = 0) {
            Comprimento = comprimento;
            Largura = largura;
        }


        public override double Perimetro()
        {
            return (2 * Comprimento) + (2 * Largura);
        }

        public override string ToString()
        {
            return $"\nRetangulo: Comprimento={Comprimento:F2} Largura={Largura:F2} "
            + $"Area={Area():F2} Perimetro={Perimetro():F2}\n";
        }

        public override double Area()
        {
            return Comprimento * Largura;
        }
    }
}

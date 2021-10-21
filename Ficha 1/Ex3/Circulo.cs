using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1ex3
{
    class Circulo: FiguraPlana
    {
        public double Raio { get; }

        public Circulo(double raio = 0) { Raio = raio; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override string ToString()
        {
            return $"\nCirculo: Raio={Raio:F2} " 
                + $"Area={Area():F2} Perimetro={Perimetro():F2}\n";
        }

    }
}

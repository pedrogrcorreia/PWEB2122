using System;

namespace f1ex3
{
    class Triangulo: FiguraPlana
    {
        public double LadoA { get; }
        public double LadoB { get; }
        public double LadoC { get; }

        public Triangulo(double ladoA = 0, double ladoB = 0, double ladoC = 0) {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }


        public override double Perimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public override string ToString()
        {
            return $"\nTriangulo: LadoA={LadoA:F2} LadoB={LadoB:F2} "
            + $"LadoC = {LadoC:F2} Area={Area():F2} Perimetro={Perimetro():F2}\n";
        }

        public override double Area()
        {
            double S = 0;
            S = this.Perimetro()/2;
            return Math.Sqrt(S*(S-LadoA)*(S-LadoB)*(S-LadoC));
        }
    }
}
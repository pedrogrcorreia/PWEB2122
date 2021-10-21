

namespace f1ex3
{
    class Quadrado: Retangulo
    {
        public Quadrado(double lado):base(lado, lado){}


        public override double Perimetro()
        {
            return base.Perimetro();
        }

        public override string ToString()
        {
            return $"\nQuadrado: Lado={Comprimento:F2}"
            + $" Area={Area():F2} Perimetro={Perimetro():F2}\n";
        }

        public override double Area()
        {
            return base.Area();
        }
    }
}
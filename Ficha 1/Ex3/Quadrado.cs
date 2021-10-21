

namespace f1ex3
{
    class Quadrado: Retangulo
    {
        public Quadrado(double lado):base(lado, lado){}

        public override string ToString()
        {
            return $"\nQuadrado: Lado={Comprimento:F2}"
            + $" Area={Area():F2} Perimetro={Perimetro():F2}\n";
        }
    }
}
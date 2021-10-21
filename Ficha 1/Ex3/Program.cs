using System;
using System.Collections.Generic;

namespace f1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FiguraPlana> FigurasPlanas = new List<FiguraPlana>();
       
            FiguraPlana r1 = new Retangulo(5, 6);
            FigurasPlanas.Add(r1);

            FiguraPlana c1 = new Circulo(7);
            FigurasPlanas.Add(c1);

            FiguraPlana t1 = new Triangulo(7, 7, 7);
            FigurasPlanas.Add(t1);

            FiguraPlana q1 = new Quadrado(4);
            FigurasPlanas.Add(q1);

            foreach (var fig in FigurasPlanas) 
                Console.WriteLine(fig);
        }
    }
}

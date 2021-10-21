using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1ex3
{
    public abstract class FiguraPlana
    {
        public abstract double Area();
        public abstract double Perimetro();
        public override string ToString() { return "Figura Plana"; }
    }
}

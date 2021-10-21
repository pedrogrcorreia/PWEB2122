using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {

        static void PrintList(IEnumerable<string> l, string t = null)
        {
            if(t != null)
                Console.WriteLine(t);

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
        }

        static void PrintListN(IEnumerable<int> l, string t = null)
        {
            if(t != null)
                Console.WriteLine(t);

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            string[] ListaUm = {"C#", "Aprender C#",
            "ASP.NET Core com C#", "Entity Framework", 
            "Bootstrap", "Identity", "Lamda", "Delegates",
            "Linq", "POO com C#"};

            string[] ListaDois = { "C#", "ASP.NET Core", "Linq",
            "Lambda e C#"};

            int[] Numeros = {10, 23, 54, 77, 85, 12, 1, 4, 53};

            // a)

            var a1 = from s in ListaUm
                    orderby s ascending
                    select s;  // query syntax

            var a2 = ListaUm.OrderBy(s => s); // method syntax

            PrintList(a1, "a) ListaUm (Query syntax)");
            PrintList(a2, "a) ListaUm (Extension method)");

            // b)

            var b1 = from s in ListaUm
                    where s.Length < 6
                    select s; // query method

            var b2 = ListaUm.Where(s => s.Length < 6); // extension method

            PrintList(b1, "b) ListaUm (Query syntax)");
            PrintList(b2, "b) ListaUm (Extension method)");


            // c)

            var c1 = (from s in ListaUm
                    where s.Contains("C#")
                    select s).Count();

            var c2 = ListaUm.Where(s => s.Contains("C#")).Count();


            Console.WriteLine("c) " + c1 + " (Query syntax)");
            Console.WriteLine("c) " + c2 + " (Extension method)");

            // d)

            var d1 = from s in ListaUm
                    select s.Split(" ").Count();
            
            var d2 = ListaUm.Select(s => s.Split(" ").Count());

            var d3 = ListaUm.Select(s => new { palavras = s.Split(" ").Count(), str = s});

            PrintListN(d1, "d) ListaUm (Query syntax)");
            PrintListN(d2, "d) ListaUm (Extension method)");
            foreach(var item in d3){
                Console.WriteLine(item.str, item.palavras);
            }
        }
    }
}

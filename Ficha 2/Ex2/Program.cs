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
            Console.WriteLine("c) " + c2 + " (Extension method)\n");

            // d)

            var d1 = from s in ListaUm
                    select s.Split(" ").Count(); // query method
            
            var d2 = ListaUm.Select(s => s.Split(" ").Count()); // extension method

            PrintListN(d1, "d) ListaUm (Query syntax)");
            PrintListN(d2, "d) ListaUm (Extension method)");
            
            var d3 = ListaUm.Select(s => new { palavras = s.Split(" ").Count(), str = s}); // new list not on exercise

            foreach(var item in d3){
                Console.WriteLine($"sentence = '{item.str}' tam = {item.palavras}");
            } // print d3
            Console.WriteLine();

            // e)

            var e1 = (from s in Numeros
                    select s).Average();

            var e2 = Numeros.Average();

            Console.WriteLine("e) Average (Query syntax) " + e1 +"\n");
            Console.WriteLine("e) Average (Extension method) " + e2 + "\n");

            // f)

            var f1 = (from s in Numeros
                    select s).Max();
            
            var f2 = Numeros.Max();

            Console.WriteLine("f) Max (Query syntax) " + f1 + "\n");
            Console.WriteLine("f) Max (Extension method) " + f2 + "\n");

            // g)

            var g1 = (from s in Numeros
                    where s <= 25 && s >= 1
                    orderby s descending
                    select s);

            var g2 = Numeros.Where(s => s >= 1 && s <= 25).OrderByDescending(s => s);

            PrintListN(g1, "g) Ascending [1-25] (Query syntax)");
            PrintListN(g2, "g) Ascending [1-25] (Extension method)");

            // h)

            var h1 = from s in ListaUm
                    join s2 in ListaDois on s equals s2
                    select s;

            var h2 = ListaUm.Intersect(ListaDois);

            PrintList(h1, "h) Common elements ListaUm & ListaDois (Query syntax)");
            PrintList(h1, "h) Common elements ListaUm & ListaDois (Extension method)");
        
            // i)
                    
            var i1 = (from s in ListaUm
                    select s).Union(from y in ListaDois select y);

            var i2 = ListaUm.Union(ListaDois);

            PrintList(i2, "i) All elements ListaUm & ListaDois not repetead (Query syntax)");
            PrintList(i2, "i) All elements ListaUm & ListaDois not repetead (Extension method)");
        
            // j)

            var j1 = from s in Numeros
                    group s by s % 2;

            Console.WriteLine("j) Query syntax");
            foreach(var group in j1){
                var s = group.Key == 0 ? "Even Numbers" : "Odd numbers";
                Console.Write(s + ": ");

                foreach(var item in group){
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var j2 = Numeros.GroupBy(s => s % 2);

            Console.WriteLine("j) Extension method");
            foreach(var group in j2){
                var s = group.Key == 0 ? "Even Numbers" : "Odd numbers";
                Console.Write(s + ": ");

                foreach(var item in group){
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // k)

            var k1 = (from s in Numeros
                    where s <= 30
                    select s).Aggregate((s, sum) => sum * s);

            var k2 = Numeros.Where(s => s <= 30).Aggregate((s, sum) => sum * s);
            Console.WriteLine("k) Product all numbers bellow 30: " + k1 + " (Query syntax)\n");
            Console.WriteLine("k) Product all numbers bellow 30: " + k2 + " (Extension method)\n");
        
            // l)
            var l1 = from s in ListaUm
                    where s.Contains("C#")
                    select new 
                    {
                        frase = s,
                        primeira = s.Trim().Split(" ").First(),
                        ultima = s.Trim().Split(" ").Length == 1 ? "NAO TEM" : s.Trim().Split(" ").Last()
                    };

            var solucao = l1;

            foreach (var s in solucao){
                Console.WriteLine("Frase: " + s.frase + "\n\tPrimeira Palavra: " +
                s.primeira + "\n\tUltima Palavra: " + s.ultima);
            }
        }
    }
}

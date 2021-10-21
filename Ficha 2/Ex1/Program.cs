using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace f2ex1
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
        static void Main(string[] args)
        {
            List<string> ListaStrings = new List<string>() {
                "C#", "Entity Framework",
                "ASP.NET MVC com C#", "Linq",
                "Lambda", "Identity Framework"
            };

            List<string> listA = new List<string>();

            foreach (var item in ListaStrings){
                if (item.Contains("C#"))
                    listA.Add(item);
            }                   // NO LINQ solution

            PrintList(listA, "Lista A:");

            var listB = from x in ListaStrings
                        where x.Contains("C#")
                        select x;                   // LINQ query method

            PrintList(listB, "Lista B:");

            var listC = ListaStrings.Where(s => s.Contains("C#")); // LINQ lambda solution

            PrintList(listC, "Lista C:");
        }
    }
}

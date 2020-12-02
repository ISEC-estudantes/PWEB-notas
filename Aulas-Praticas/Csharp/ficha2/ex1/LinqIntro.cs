using System;
using System.Collections.Generic;
using System.Linq;
//TODO: acabar de fazer a ficha 2
namespace f2
{
    public class LinqIntro
    {

        public static void ex1()
        {
            List<string> ListaStrings = new List<string>() { "C#", "Entity Framework", "ASP.NET MVC com C#", "Linq", "Lambda", "Identity Framework" };

            var ListA = new List<string>();
            foreach (var x in ListaStrings) if (x.Contains("C#")) ListA.Add(x);
            var ListB = from s in ListaStrings where s.Contains("C#") select s;
            var ListC = ListaStrings.Where(l => l.Contains("C#"));

        }

        public static void ex2c()
        {
            string[] ListaUm = {
                "C#", "Aprender C#","ASP.NET MVC com C#",
                "Entity Framework","Bootstrap","Identity",
                "Lambda","Delegates","Linq","POO com C# "
            };
            string[] ListaDois = { "C#", "ASP.NET MVC", "Linq", "Lambda e C#" };
            int[] Numeros = { 10, 23, 54, 77, 85, 12, 1, 4, 53 };


            // query syntax
            var ListB = from s in ListaUm where s.Contains("C#") select s;
            Console.WriteLine(ListB.Count());

            //extension methods
            Console.WriteLine(
                ListaUm.Count(l => l.Contains("C#"))
            );

            //B
            //query syntax
            // ListaB = 

            //extesion methods
            Console.WriteLine(
            // ListaUm.
            );

            //A)
            //items ordenados por ordem alfabetica
            Console.WriteLine("--------");
            var listA = from s in ListaUm orderby s select s;
            foreach (string x in listA)
            {
                Console.WriteLine(x);
            }

            var listAa = ListaUm.OrderBy(l => l);
            foreach (string x in listAa)
            {
                Console.WriteLine(x);
            }

            


        }
    }
}
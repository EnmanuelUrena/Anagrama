using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrama
{   
    class Program
    {
        static bool verificarAnagrama(string cadena1, string cadena2){
            bool esAnagrama = true;
            if (cadena1 == null || cadena2 == null)
            {
                throw new NullReferenceException();
            }
            var lista1 = new List<char>();
            var lista2 = new List<char>();
            lista1 = cadena1.ToList();
            lista2 = cadena2.ToList();
            lista1.Sort();
            lista2.Sort();

            for (int i = 0; i < cadena1.Length && esAnagrama; i++)
            {
                if (lista1[i] == lista2[i])
                {
                    continue;
                }
                else
                {
                    esAnagrama = false;
                }
            }

            return esAnagrama;
        }
        static void Main(string[] args)
        {
            System.Console.Write("Introduce una palabra:");
            string palabra1 = Console.ReadLine();
            System.Console.Write("Introduce otra palabra:");
            string palabra2 = Console.ReadLine();

            System.Console.WriteLine(verificarAnagrama(palabra1,palabra2));
        }
    }
}

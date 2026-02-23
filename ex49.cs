using System;
using System.Collections.Generic;
using System.Linq; 

namespace EX_C__46_60
{
    internal class ex49
    {
        public static void EX49()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

            var pares = numeros.Where(n => n % 2 == 0).ToList();

            Console.WriteLine($"Numeros Pares: {string.Join(", ", pares)}");
        }
    }
}
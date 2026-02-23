using System;
using System.Collections.Generic;
using System.Text;

namespace EX_C__46_60
{
    internal class ex53
    {
        public static void EX53()
        {
            string frase = "Democracia Corinthiana";

            string palavra = "Democracia";

            if (frase.Contains(palavra))
            {
                Console.WriteLine($"A frase {frase} contem a palavra {palavra}");
            }
            else
            {
                Console.WriteLine($"A frase {frase} não contem a palavra {palavra}");
            }

        }
    }
}

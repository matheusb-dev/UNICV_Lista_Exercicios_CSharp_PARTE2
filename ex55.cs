using System;
using System.Collections.Generic;
using System.Text;

namespace EX_C__46_60
{
    internal class ex55
    {
        public static void EX55()
        {
            string palavra = "Corinthians";
            string carcteres = palavra.Substring(0, 3);

            Console.WriteLine($"Na palavra {palavra} os 3 primeiros caracteres sao {carcteres}");

        }
    }
}

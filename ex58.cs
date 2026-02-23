using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EX_C__46_60
{
    internal class ex58
    {
        public static void EX58()
        {
            DateTime hoje = DateTime.Now;

            Console.WriteLine(hoje);

            DateTime dataFutura = hoje.AddDays(30);

            Console.WriteLine(dataFutura);

        }
    }
}

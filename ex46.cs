using System;
using System.Collections.Generic;
using System.Text;

namespace EX_C__46_60
{
    internal class ex46
    {
        public static void EX46()
        {
            string cachorro = "Labrador";

            string invertida = new string(cachorro.Reverse().ToArray());

            Console.WriteLine(invertida);
        }
    }
}

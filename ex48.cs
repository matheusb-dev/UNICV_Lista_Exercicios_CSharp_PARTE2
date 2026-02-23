using System;
using System.Collections.Generic;
using System.Text;

namespace EX_C__46_60
{
    internal class ex48
    {
        public static void EX48()
        {
            int numero = 10;

            Console.WriteLine($"Numero Original: {numero}");

            ModificarValor(ref numero);

            Console.WriteLine($"Numero Modificado: {numero}");
        }


        public static void ModificarValor(ref int num)
        {
            num = 20;
        }
    }
}

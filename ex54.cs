using System;
using System.Collections.Generic;
using System.Text;

namespace EX_C__46_60
{
    internal class ex54
    {
        public static void EX54()
        {
            string frase = "Rato roeu a roupa do rei";

            Console.WriteLine($"Frase Original: {frase}");

            ModificarPalavra(ref frase);

            Console.WriteLine($"Frase Alterada: {frase}");
        }

        public static void ModificarPalavra(ref string palavra)
        {
            palavra = "Cachorro roeu a roupa do rei";
        }
    }
}

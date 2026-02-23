using System;
using System.Globalization;

namespace EX_C__46_60
{
    internal class ex56
    {
        public static void EX56()
        {
            string dataFormatada = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy",new CultureInfo("pt-BR"));

            Console.WriteLine(dataFormatada);
        }
    }
}
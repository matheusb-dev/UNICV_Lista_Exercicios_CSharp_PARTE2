using System;

namespace EX_C__46_60
{
    internal class ex60
    {
        public static void EX60()
        {
            DateTime hoje = DateTime.Now;

            DateTime ultimoDiaDoAno = new DateTime(hoje.Year, 12, 31);

            TimeSpan diferenca = ultimoDiaDoAno - hoje;

            Console.WriteLine($"Faltam {diferenca.Days} dias para o final do ano.");
        }
    }
}
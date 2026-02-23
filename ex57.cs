using System;
using System.Globalization;

namespace EX_C__46_60
{
    internal class ex57
    {
        public static void EX57()
        {
            Console.Write("Digite a primeira data (dd/MM/yyyy): ");
            DateTime data1 = DateTime.ParseExact(
                Console.ReadLine(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture);

            Console.Write("Digite a segunda data (dd/MM/yyyy): ");
            DateTime data2 = DateTime.ParseExact(
                Console.ReadLine(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture);

            TimeSpan diferenca = data2 - data1;

            Console.WriteLine($"Diferença em dias: {Math.Abs(diferenca.Days)}");
        }
    }
}
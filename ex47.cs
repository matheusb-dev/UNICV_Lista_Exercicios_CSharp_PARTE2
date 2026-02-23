using System;

namespace EX_C__46_60
{
    internal class ex47
    {
        public static void EX47()
        {
            Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;

            if (dataNascimento.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            Console.WriteLine($"Sua idade é: {idade} anos");
        }
    }
}
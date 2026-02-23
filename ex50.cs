using System;
using System.Linq;

namespace EX_C__46_60
{
    internal class ex50
    {
        public static void EX50()
        {
            Console.WriteLine("Pelo menos 8 caracteres");
            Console.WriteLine("1 letra maiuscula");
            Console.WriteLine("1 numero");
            Console.WriteLine("1 caractere especial");
            Console.Write("Digite uma senha: ");
            string senha = Console.ReadLine();

            if (ValidarSenha(senha))
                Console.WriteLine("Senha válida ");
            else
                Console.WriteLine("Senha inválida ");
        }

        private static bool ValidarSenha(string senha)
        {
            if (senha.Length < 8)
                return false;

            bool temMaiuscula = senha.Any(char.IsUpper);
            bool temNumero = senha.Any(char.IsDigit);
            bool temEspecial = senha.Any(ch => !char.IsLetterOrDigit(ch));

            return temMaiuscula && temNumero && temEspecial;
        }
    }
}
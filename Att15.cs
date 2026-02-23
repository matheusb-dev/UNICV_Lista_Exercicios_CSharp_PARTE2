/** NOME: Matheus Bezerra Domingos
   RA: 166479-2024
   
   NOME: Otávio Augusto Zangelmi Costa
   RA: 159752-2023

   NOME: Luiz Eduardo Marques da Silva 
   RA:168685-2024

   NOME: Gabriel de Souza Mendes
   RA: 162874-2023

*/

using System;

class Att15
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o operador (+, -, *, /):");
        char op = char.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        double y = double.Parse(Console.ReadLine());

        switch (op)
        {
            case '+': Console.WriteLine(x + y); break;
            case '-': Console.WriteLine(x - y); break;
            case '*': Console.WriteLine(x * y); break;
            case '/':
                if (y != 0) Console.WriteLine(x / y);
                else Console.WriteLine("Erro: divisão por zero");
                break;
            default: Console.WriteLine("Operador inválido"); break;
        }
    }
}
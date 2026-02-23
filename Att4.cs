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

class Att4
{
    static void Main()
    {
        Console.WriteLine("Escreva 3 numeros:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int maior = a;

        if (b > maior) maior = b;
        if (c > maior) maior = c;

        Console.WriteLine($"Maior: {maior}");
    }
}
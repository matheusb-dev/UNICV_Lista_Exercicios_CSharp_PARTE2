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

class Att3
{
    static void Main()
    {
        Console.WriteLine("Escreva um numero:");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0) Console.WriteLine("Par");
        else Console.WriteLine("Ímpar");
    }
}
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

class Att6
{
    static void Main()
    {
        Console.WriteLine("Escreva um ano:");
        int ano = int.Parse(Console.ReadLine());

        if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            Console.WriteLine("Bissexto");
        else
            Console.WriteLine("Não é bissexto");
    }
}
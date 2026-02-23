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

class Att2
{
    static void Main()
    {
        Console.WriteLine("Escreva a sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18) Console.WriteLine("Maior de idade");
        else Console.WriteLine("Menor de idade");
    }
}
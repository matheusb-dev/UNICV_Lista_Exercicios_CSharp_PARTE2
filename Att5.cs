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

class Att5
{
    static void Main()
    {
        Console.WriteLine("Escreva sua primeira nota:");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva sua segunda nota:");
        double n2 = double.Parse(Console.ReadLine());

        double media = (n1 + n2) / 2;

        if (media >= 7) Console.WriteLine("Aprovado");
        else Console.WriteLine("Reprovado");
    }
}
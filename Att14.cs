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

class Att14
{
    static void Main()
    {
        Console.WriteLine("Digite os lados do triângulo 1/3:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite os lados do triângulo 2/3:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite os lados do triângulo 3/3:");
        int c = int.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("Forma triângulo");
        else
            Console.WriteLine("Não forma triângulo");

        if (a == b && b == c) Console.WriteLine("Equilátero");
        else if (a == b || a == c || b == c) Console.WriteLine("Isósceles");
        else Console.WriteLine("Escaleno");

    }
}
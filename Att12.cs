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

class Att12
{
    static void Main()
    {
        
        Console.WriteLine("Digite a nota (0-10):");
        int nota = int.Parse(Console.ReadLine());

        switch (nota / 10)
        {
            case 10:
            case 9: Console.WriteLine("A"); break;
            case 8: Console.WriteLine("B"); break;
            case 7: Console.WriteLine("C"); break;
            case 6: Console.WriteLine("D"); break;
            default: Console.WriteLine("F"); break;
        }
    }
}
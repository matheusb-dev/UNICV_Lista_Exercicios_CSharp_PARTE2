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

class Att11
{
    static void Main()
    {   
        Console.WriteLine("Digite qual o dia da semana em numero:");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1: Console.WriteLine("Domingo"); break;
            case 2: Console.WriteLine("Segunda"); break;
            case 3: Console.WriteLine("Terça"); break;
            case 4: Console.WriteLine("Quarta"); break;
            case 5: Console.WriteLine("Quinta"); break;
            case 6: Console.WriteLine("Sexta"); break;
            case 7: Console.WriteLine("Sábado"); break;
            default: Console.WriteLine("Inválido"); break;
        }
    }
}
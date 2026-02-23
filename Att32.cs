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

using System.Collections;

class Att32
{
    static void Main()
    {
        List<int> nInterios = new List<int>();

        nInterios.Add(1);
        nInterios.Add(25);
        nInterios.Add(34);
        nInterios.Add(77);
        nInterios.Add(0);

        foreach (int n in nInterios)
        {
            Console.WriteLine($"Lista Original: {n}");
        }

        Console.WriteLine("\n");

        nInterios.Remove(0);

        Console.WriteLine("Remove o 1º:");

        Console.WriteLine("\n");

        foreach (int n in nInterios)
        {
            Console.WriteLine($"Lista Modificada {n}");
        }

        
    }
}


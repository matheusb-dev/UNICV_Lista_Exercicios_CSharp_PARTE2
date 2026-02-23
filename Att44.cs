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

public class Att44
{
    public static void Main()
    {
        int numero = 42;

        if (EhPar(numero))
        {
            Console.WriteLine($"{numero} é Par!");
        }
        else
        {
            Console.WriteLine($"{numero} é Ímpar!");
        }
    }

    
    public static bool EhPar(int n)
    {
        return n % 2 == 0;
    }
}
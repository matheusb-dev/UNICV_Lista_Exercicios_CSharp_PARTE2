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

using System.Collections.Generic;

public class Att45
{
    public static void Main()
    {
        List<int> numeros = new List<int> { 10, 20, 30, 40 };

        int resultado = SomarLista(numeros);

        Console.WriteLine($"A soma total é: {resultado}");
    }

    public static int SomarLista(List<int> lista)
    {
        int soma = 0;
        foreach (int numero in lista)
        {
            soma += numero;
        }
        return soma;
    }
}
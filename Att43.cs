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

public class Att43
{
    public static void Main()
    {
        List<double> notas = new List<double> { 8.5, 7.0, 9.2, 6.8 };

      
        double mediaLinq = notas.Average();

       
        double mediaManual = CalcularMediaLista(notas);

        Console.WriteLine($"Média (LINQ): {mediaLinq:F2}");
        Console.WriteLine($"Média (Manual): {mediaManual:F2}");
    }

    public static double CalcularMediaLista(List<double> valores)
    {
        if (valores.Count == 0) return 0;

        double soma = 0;
        foreach (var v in valores)
        {
            soma += v;
        }
        return soma / valores.Count;
    }
}
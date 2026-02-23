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


public class Att35
{
	static void Main()
	{
        List<int> nInteiros = new List<int>() { 25, 85, 41, 80, 900 };

        List<int> nInteirosDescrecente = nInteiros.OrderByDescending(x => x).ToList();

        foreach(int i in nInteirosDescrecente)
        {
            Console.WriteLine(i);
        }
    }
}

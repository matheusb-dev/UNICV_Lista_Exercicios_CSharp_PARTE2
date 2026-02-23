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


class Att34
{
	static void Main()
	{
		List<int> nInteiros = new List<int>() { 25, 85, 41, 80, 900 };

		nInteiros.Sort();

		foreach (int i in nInteiros)
		{

			Console.WriteLine(i);
		}
	}
}

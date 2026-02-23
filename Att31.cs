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

class Att31
{
    static void Main(string[] args)
    {
        List<int> nInteiros = new List<int>();

        nInteiros.Add(1);
        nInteiros.Add(25);
        nInteiros.Add(34);
        nInteiros.Add(77);
        nInteiros.Add(0);

        foreach (int i in nInteiros)
        {
            Console.WriteLine(i);
        }
    }
}
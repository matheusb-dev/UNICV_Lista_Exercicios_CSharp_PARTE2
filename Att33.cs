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

class Att33
{

    static void Main()
    {
        List<int> nInteiros = new List<int>() { 1, 2, 3, 4, 5 };

        Console.Write("Digite um numero: ");

        if(int.TryParse(Console.ReadLine(), out int nBusca))
        {

            if (nInteiros.Contains(nBusca)){
                Console.WriteLine($"Numero {nBusca} , está na lista");
            }
            else
            {
                Console.WriteLine($"Numero {nBusca} , não está na lista");
            }
        }
        else
        {
            Console.Write("Digite outro numero: ");
        }
            
    }
}
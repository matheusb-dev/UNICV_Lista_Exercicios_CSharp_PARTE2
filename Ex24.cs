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

int positivos = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write("Digite um número: ");
    int n = int.Parse(Console.ReadLine());

    if (n > 0)
        positivos++;
}

Console.WriteLine("Quantidade de positivos: " + positivos);

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

int[] numeros = { 10, 20, 30, 40 };
int soma = 0;

foreach (int n in numeros)
{
    soma += n;
}

Console.WriteLine("Soma = " + soma);

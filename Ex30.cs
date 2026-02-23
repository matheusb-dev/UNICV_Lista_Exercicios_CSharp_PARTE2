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

int[] numeros = { 1, 2, 3, 4, 5 };
int tamanho = numeros.Length;

for (int i = 0; i < tamanho / 2; i++)
{
    int temp = numeros[i];
    numeros[i] = numeros[tamanho - 1 - i];
    numeros[tamanho - 1 - i] = temp;
}

foreach (int n in numeros)
{
    Console.WriteLine(n);
}
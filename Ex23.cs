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

int soma = 0;
int contador = 0;
int numero;

do
{
    Console.Write("Digite um número (0 para sair): ");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0)
    {
        soma += numero;
        contador++;
    }

} while (numero != 0);

if (contador > 0)
{
    double media = (double)soma / contador;
    Console.WriteLine("Média = " + media);
}
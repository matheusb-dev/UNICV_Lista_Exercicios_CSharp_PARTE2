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

string[] palavras = { "computador", "casa", "programação", "sol", "internet" };
int contador = 0;

foreach (string palavra in palavras)
{
    if (palavra.Length > 5)
        contador++;
}

Console.WriteLine("Palavras com mais de 5 letras: " + contador);

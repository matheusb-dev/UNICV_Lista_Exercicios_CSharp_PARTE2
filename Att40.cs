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

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; } 

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

public class Att40
{
    public static void Main()
    {
        
        List<Produto> listaProdutos = new List<Produto>();

       
        listaProdutos.Add(new Produto("Apple Watch S9", 2500));
        listaProdutos.Add(new Produto("ZFlip 5", 4000));
        listaProdutos.Add(new Produto("iPhone 13 Mini", 2500));

       
        Console.WriteLine($"Total de produtos: {listaProdutos.Count}");

        foreach (var p in listaProdutos)
        {
            Console.WriteLine($"Produto: {p.Nome} - Preço: R$ {p.Preco}");
        }
    }
}
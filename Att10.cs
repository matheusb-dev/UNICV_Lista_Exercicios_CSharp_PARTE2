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

class Att10
{
    static void Main()
    {
        Console.WriteLine("1 - Cadastrar\n2 - Editar\n3 - Excluir\n4 - Sair");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1: Console.WriteLine("Cadastrar"); break;
            case 2: Console.WriteLine("Editar"); break;
            case 3: Console.WriteLine("Excluir"); break;
            case 4: Console.WriteLine("Sair"); break;
            default: Console.WriteLine("Opção inválida"); break;
        }
    }
}
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

public class Att37

{
	static void Main()
	{
        Dictionary<string, float> Alunos = new Dictionary<string, float>();

        Alunos.Add("Matheus", 4);
        Alunos.Add("Luiz", 10);
        Alunos.Add("Gabriel", 7);
        Alunos.Add("Otavio", 8);

        Console.Write("Digite o nome do aluno: ");
        string nomeBusca = Console.ReadLine();


        if (Alunos.ContainsKey(nomeBusca))
        {
            float nota = Alunos[nomeBusca];
            Console.WriteLine($"O aluno {nomeBusca} está na lista. Nota: {nota}");
        }
        else
        {
            Console.WriteLine($"O aluno '{nomeBusca}' não foi encontrado.");
        }
    }
}

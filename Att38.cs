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

public class Att38
{
	static void Main()
	{
        Dictionary<string, float> Alunos = new Dictionary<string, float>();

        Alunos.Add("Matheus", 4);
        Alunos.Add("Luiz", 10);
        Alunos.Add("Gabriel", 7);
        Alunos.Add("Otavio", 8);

        foreach (KeyValuePair<string, float> item in Alunos)
        {
            
            Console.WriteLine("Aluno: {0} - Nota: {1}", item.Key, item.Value);
        }

        Console.WriteLine("\n");
    }
}

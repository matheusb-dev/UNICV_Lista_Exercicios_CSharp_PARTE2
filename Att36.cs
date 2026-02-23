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

public class Att36
{
	static void Main()
	{
		Dictionary<string, float> Aluno = new Dictionary<string, float>();

		Aluno.Add("Matheus", 4);
        Aluno.Add("Luiz", 10);
        Aluno.Add("Gabriel", 7);
        Aluno.Add("Otavio", 8);


        foreach (KeyValuePair<string, float> alunos in Aluno)
        {
            Console.Write("Nome: {0}, Nota: {1} \n", alunos.Key, alunos.Value);
        }
    
    }
}

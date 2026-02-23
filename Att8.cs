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

class Att8
{
    static void Main()
    {
        Console.WriteLine("Escreva seu peso:");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva sua altura:");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine($"IMC: {imc:F2}");

        if (imc < 18.5) Console.WriteLine("Abaixo do peso");
        else if (imc < 25) Console.WriteLine("Peso normal");
        else if (imc < 30) Console.WriteLine("Sobrepeso");
        else Console.WriteLine("Obesidade");

    }
}
/*Exercício 1) C#
Fazer um programa para ler um número
inteiro, e depois dizer se este número é par
ou não.*/

using System;
class Program
{
    static void Main()
    {Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}
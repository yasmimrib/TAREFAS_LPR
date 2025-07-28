/*Exercício 1) VETOR: Construa um algoritmo
que leia 10 números inteiros e armazene-os
em um vetor (use o for para fazer a leitura).
Depois, crie automaticamente dois
vetores, um contendo apenas os números
pares e outro os números ímpares
digitados.*/

using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Insira dez números inteiros separados por espaço: ");
        string entrada = Console.ReadLine();
        string[] partes = entrada.Split(' ');

        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(partes[i]);
        }

        int[] pares = Array.FindAll(numeros, n => n % 2 == 0);
        int[] impares = Array.FindAll(numeros, n => n % 2 != 0);

        Console.WriteLine("Números pares:");
        foreach (int n in pares)
            Console.Write(n + " ");

        Console.WriteLine("\nNúmeros ímpares:");
        foreach (int n in impares)
            Console.Write(n + " ");
    }
}
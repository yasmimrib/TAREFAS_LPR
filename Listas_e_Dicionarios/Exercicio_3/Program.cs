/*Exercício 3) RESOLVA EM C#
Construa um dicionário de X pares chave-valor
onde as chaves são nomes de pessoas e os
valores são suas respectivas idades.
Encontre e imprima todos os nomes de
pessoas com idade acima da média.
Encontre e imprima o nome da pessoa mais
velha e o nome da pessoa mais nova.
Remova todas as pessoas com idade igual a
um valor Y (fornecido pelo usuário) e imprima
o dicionário atualizado.*/

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>();
        Console.WriteLine("Quantas pessoas deseja adicionar?");
        int quantidade = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("Digite o nome da pessoa:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da pessoa:");
            int idade = int.Parse(Console.ReadLine());
            pessoas[nome] = idade;
        }
        Console.WriteLine("A média de idade é: " + pessoas.Values.Average());
        Console.WriteLine("\nPessoas com idade acima da média:");
        double media = pessoas.Values.Average();
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > media)
            {
                Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
            }
        }
        Console.WriteLine("\nPessoa mais velha:");
var maisVelha = pessoas.Aggregate((x, y) => x.Value > y.Value ? x : y);
Console.WriteLine($"{maisVelha.Key} - {maisVelha.Value} anos");

Console.WriteLine("\nPessoa mais nova:");
var maisNova = pessoas.Aggregate((x, y) => x.Value < y.Value ? x : y);
Console.WriteLine($"{maisNova.Key} - {maisNova.Value} anos");

Console.WriteLine("\nDigite um valor Y para remover pessoas com essa idade:");
int valorY = int.Parse(Console.ReadLine());

// Filtra as pessoas com a idade diferente de valorY
var pessoasFiltradas = pessoas.Where(p => p.Value != valorY).ToDictionary(p => p.Key, p => p.Value);

// Verifica se houve alguma remoção
if (pessoas.Count == pessoasFiltradas.Count)
{
    Console.WriteLine($"\nNão há ninguém com {valorY} anos.");
}
else
{
    Console.WriteLine("\nDicionário atualizado:");
    foreach (var pessoa in pessoasFiltradas)
    {
        Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
    }
}
pessoas = pessoasFiltradas;

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
        }


    }
}

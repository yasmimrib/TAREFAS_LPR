/*Exercício 1) RESOLVA EM C#
Construa uma lista de X nomes aleatórios
A saída deve ser mostrada em uma ou
mais linhas. Cada linha tem uma lista de
nomes ordenados por tamanho,
começando com o menor. Em cada linha,
só pode ser mostrado um nome de
determinado tamanho, e os demais
nomes com o mesmo tamanho devem ser
apresentados nas linhas seguintes. Você
deve seguir a ordem de digitação.*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        Console.WriteLine("Primeiro, forneça a quantidade de nomes a serem listados:");
        int quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Agora, forneça os nomes um por um:");
        for (int i = 0; i < quantidade; i++)
        {
            string nome = Console.ReadLine();
            nomes.Add(nome);
        }
        Console.WriteLine("\nNomes ordenados por tamanho:");
        List<string> listaOrdenada = nomes.OrderBy(n => n.Length).ToList();
        List<string> listaAgrupada = listaOrdenada.GroupBy(n => n.Length)
                                                    .Select(g => string.Join(", ", g))
                                                    .ToList();
        foreach (var grupo in listaAgrupada)
        {
            Console.WriteLine(grupo);
        }
        
       Console.WriteLine("Fim da lista.");
    }
}
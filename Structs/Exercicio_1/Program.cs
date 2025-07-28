/*Exercício 1) RESOLVA EM C#
Defina uma struct Produto que contenha
os seguintes campos: Nome, Codigo,
Preco e Quantidade. Crie um programa
que permita ao usuário inserir dados de 3
produtos e, em seguida, exiba o valor
total em estoque (considerando o preço e
a quantidade de cada produto).
*/
using System;

public struct Produto
{
    public string Nome;
    public int Codigo;
    public decimal Preco;
    public int Quantidade;

}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];
        decimal valorTotalEstoque = 0;

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Digite os dados do produto {i + 1}:");
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();
            Console.Write("Código: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());
            Console.Write("Preço: ");
            produtos[i].Preco = decimal.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());

            valorTotalEstoque += produtos[i].Preco * produtos[i].Quantidade;
        }

        Console.WriteLine($"Valor total em estoque: R$ {valorTotalEstoque:F2}");
    }
}
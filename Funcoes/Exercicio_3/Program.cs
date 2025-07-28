/*Exercício 3)
Desenvolva um programa em C# que
simule um sistema de seleção de heróis da
Marvel para uma equipe*/

using System;

class Program
{
    static string nome1 = null, nome2 = null, nome3 = null, nome4 = null, nome5 = null;
    static string poder1 = null, poder2 = null, poder3 = null, poder4 = null, poder5 = null;
    static int pontuacao1 = 0, pontuacao2 = 0, pontuacao3 = 0, pontuacao4 = 0, pontuacao5 = 0;
    static int equipe1 = 0, equipe2 = 0, equipe3 = 0;

    static void Main()
    {
        Menu();
    }

    static void CadastrarHerois()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Cadastro do herói {i}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Poder: ");
            string poder = Console.ReadLine();
            Console.Write("Pontuação: ");
            int pontuacao = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                nome1 = nome; poder1 = poder; pontuacao1 = pontuacao;
            }
            else if (i == 2)
            {
                nome2 = nome; poder2 = poder; pontuacao2 = pontuacao;
            }
            else if (i == 3)
            {
                nome3 = nome; poder3 = poder; pontuacao3 = pontuacao;
            }
            else if (i == 4)
            {
                nome4 = nome; poder4 = poder; pontuacao4 = pontuacao;
            }
            else if (i == 5)
            {
                nome5 = nome; poder5 = poder; pontuacao5 = pontuacao;
            }

            Console.WriteLine($"Herói {nome} cadastrado com sucesso!\n");
        }
    }

    static void SelecaoEquipe()
    {
        Console.WriteLine("Seleção de Equipe:");
        Console.WriteLine("Heróis disponíveis:");
        if (nome1 != null) Console.WriteLine("1 - " + nome1 + " | " + poder1 + " | Pontuação: " + pontuacao1);
        if (nome2 != null) Console.WriteLine("2 - " + nome2 + " | " + poder2 + " | Pontuação: " + pontuacao2);
        if (nome3 != null) Console.WriteLine("3 - " + nome3 + " | " + poder3 + " | Pontuação: " + pontuacao3);
        if (nome4 != null) Console.WriteLine("4 - " + nome4 + " | " + poder4 + " | Pontuação: " + pontuacao4);
        if (nome5 != null) Console.WriteLine("5 - " + nome5 + " | " + poder5 + " | Pontuação: " + pontuacao5);

        Console.Write("Escolha o número do 1º herói para a equipe: ");
        equipe1 = int.Parse(Console.ReadLine());
        Console.Write("Escolha o número do 2º herói para a equipe: ");
        equipe2 = int.Parse(Console.ReadLine());
        Console.Write("Escolha o número do 3º herói para a equipe: ");
        equipe3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Equipe selecionada com sucesso!\n");
    }

    static void PontuacaoTotal()
    {
        int total = 0;
        if (equipe1 == 1) total += pontuacao1;
        else if (equipe1 == 2) total += pontuacao2;
        else if (equipe1 == 3) total += pontuacao3;
        else if (equipe1 == 4) total += pontuacao4;
        else if (equipe1 == 5) total += pontuacao5;

        if (equipe2 == 1) total += pontuacao1;
        else if (equipe2 == 2) total += pontuacao2;
        else if (equipe2 == 3) total += pontuacao3;
        else if (equipe2 == 4) total += pontuacao4;
        else if (equipe2 == 5) total += pontuacao5;

        if (equipe3 == 1) total += pontuacao1;
        else if (equipe3 == 2) total += pontuacao2;
        else if (equipe3 == 3) total += pontuacao3;
        else if (equipe3 == 4) total += pontuacao4;
        else if (equipe3 == 5) total += pontuacao5;

        Console.WriteLine("Pontuação total da equipe: " + total + "\n");
    }

    static void ExibicaoEquipe()
    {
        Console.WriteLine("Equipe escolhida:");
        if (equipe1 == 1) Console.WriteLine(nome1 + " | " + poder1 + " | Pontuação: " + pontuacao1);
        else if (equipe1 == 2) Console.WriteLine(nome2 + " | " + poder2 + " | Pontuação: " + pontuacao2);
        else if (equipe1 == 3) Console.WriteLine(nome3 + " | " + poder3 + " | Pontuação: " + pontuacao3);
        else if (equipe1 == 4) Console.WriteLine(nome4 + " | " + poder4 + " | Pontuação: " + pontuacao4);
        else if (equipe1 == 5) Console.WriteLine(nome5 + " | " + poder5 + " | Pontuação: " + pontuacao5);

        if (equipe2 == 1) Console.WriteLine(nome1 + " | " + poder1 + " | Pontuação: " + pontuacao1);
        else if (equipe2 == 2) Console.WriteLine(nome2 + " | " + poder2 + " | Pontuação: " + pontuacao2);
        else if (equipe2 == 3) Console.WriteLine(nome3 + " | " + poder3 + " | Pontuação: " + pontuacao3);
        else if (equipe2 == 4) Console.WriteLine(nome4 + " | " + poder4 + " | Pontuação: " + pontuacao4);
        else if (equipe2 == 5) Console.WriteLine(nome5 + " | " + poder5 + " | Pontuação: " + pontuacao5);

        if (equipe3 == 1) Console.WriteLine(nome1 + " | " + poder1 + " | Pontuação: " + pontuacao1);
        else if (equipe3 == 2) Console.WriteLine(nome2 + " | " + poder2 + " | Pontuação: " + pontuacao2);
        else if (equipe3 == 3) Console.WriteLine(nome3 + " | " + poder3 + " | Pontuação: " + pontuacao3);
        else if (equipe3 == 4) Console.WriteLine(nome4 + " | " + poder4 + " | Pontuação: " + pontuacao4);
        else if (equipe3 == 5) Console.WriteLine(nome5 + " | " + poder5 + " | Pontuação: " + pontuacao5);

        Console.WriteLine();
    }

    static void Menu()
    {
        int opcao = -1;
        while (opcao != 0)
        {
            Console.WriteLine("1 - Cadastrar Heróis");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Pontuação Total da Equipe");
            Console.WriteLine("4 - Exibir Equipe");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) CadastrarHerois();
            else if (opcao == 2) SelecaoEquipe();
            else if (opcao == 3) PontuacaoTotal();
            else if (opcao == 4) ExibicaoEquipe();
            else if (opcao == 0) Console.WriteLine("Saindo...");
            else Console.WriteLine("Opção inválida!");
        }
    }
}
/*Exercício 3) C#
Suponha que você está desenvolvendo um jogo
de RPG. Você é responsável por implementar a
mecânica de habilidades especiais para
diferentes classes de personagens. Cada classe
tem suas próprias habilidades especiais.
Crie um programa que permita ao jogador
escolher uma classe de personagem e, em
seguida, exiba suas habilidades especiais
correspondentes.*/

  
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma classe de personagem:");
        Console.WriteLine("1. Guerreiro \n 2. Mago \n 3. Arqueiro");
        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1)
        {
            Console.WriteLine("Habilidades do Guerreiro:");
            Console.WriteLine("- Ataque Poderoso");
            Console.WriteLine("- Defesa Robusta");
            Console.WriteLine("- Grito de Guerra");
        }
        else if (escolha == 2)
        {
            Console.WriteLine("Habilidades do Mago:");
            Console.WriteLine("- Bola de Fogo");
            Console.WriteLine("- Escudo Mágico");
            Console.WriteLine("- Teleporte");
        }
        else if (escolha == 3)
        {
            Console.WriteLine("Habilidades do Arqueiro:");
            Console.WriteLine("- Tiro Preciso");
            Console.WriteLine("- Flecha Explosiva");
            Console.WriteLine("- Camuflagem");
        }
        else
        {
            Console.WriteLine("Classe inválida. Por favor, escolha 1, 2 ou 3.");
        } 
    }
}
/*Exercício 2)
DO WHILE: Construa um algoritmo de adivinhação
de números. Com as linhas abaixo, o algoritmo
gerará um número inteiro aleatório de 1a 100:
(C#)
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);
(C++)
random_device numAleatorio ;
uniform_int_distribution<> distribuicao(1,100);
int valorInteiro = distribuicao(numAleatorio);
O seu trabalho é elaborar um algoritmo em que o
usuário possa digitar números no console até
acertar o número inteiro aleatório valorInteiro, de 1 a
100. A cada chute, o programa deve responder com
“chutou alto”, “chutou baixo” ou “acertou”. Após
acertar, deve ser mostrado quantas tentativas foram
usadas para descobrir o número. 
*/
using System;

class Program{
    static void Main()
    {
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 100);
        int chute;
        int tentaivas = 0;

        do
        {
            Console.Write("Digite um número entre 1 e 100 para tentar adivinhar: ");
            chute = int.Parse(Console.ReadLine());

            if (chute < valorInteiro)
            {
                Console.WriteLine("O número é maior que o seu chute.");
                tentaivas++;
            }
            else if (chute > valorInteiro)
            {
                Console.WriteLine("O número é menor que o seu chute.");
                tentaivas++;
            }
            else
            {
                Console.WriteLine("Parabéns! Você acertou o número em " + (tentaivas + 1) + " tentativas.");
            }
        } while (chute != valorInteiro);
    }
}
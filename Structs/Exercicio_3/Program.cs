using System;

struct Heroi
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

class Program
{
    static Heroi[] herois = new Heroi[5];

    static void CadastarHeroi()
    {
        int contador = 0;

        while (contador < 5)
        {
            Console.WriteLine($"Cadastro do Herói {contador + 1}:");
            Console.Write("Nome: ");
            herois[contador].Nome = Console.ReadLine();
            Console.Write("Poder: ");
            herois[contador].Poder = Console.ReadLine();
            Console.Write("Pontuação: ");
            herois[contador].Pontuacao = int.Parse(Console.ReadLine());

            contador++;
            Console.WriteLine("Herói cadastrado com sucesso!\n");
        }
    }

    static void EscolherEquipe()
    {
        Console.WriteLine("Heróis cadastrados:");
        for (int i = 0; i < herois.Length; i++)
        {
            if (!string.IsNullOrEmpty(herois[i].Nome))
            {
                Console.WriteLine($"{i + 1}. {herois[i].Nome} - Poder: {herois[i].Poder}, Pontuação: {herois[i].Pontuacao}");
            }
        }

        Console.WriteLine("\nSelecione 3 heróis para sua equipe (digite os números separados por espaço):");
        string[] escolhas = Console.ReadLine().Split(' ');
        if (escolhas.Length != 3)
        {
            Console.WriteLine("Você deve selecionar exatamente 3 heróis.");
            return;
        }

        Console.WriteLine("Sua equipe selecionada:");
        foreach (var escolha in escolhas)
        {
            int index = int.Parse(escolha) - 1;
            if (index >= 0 && index < herois.Length && !string.IsNullOrEmpty(herois[index].Nome))
            {
                Console.WriteLine($"{herois[index].Nome} - Poder: {herois[index].Poder}, Pontuação: {herois[index].Pontuacao}");
            }
            else
            {
                Console.WriteLine($"Herói inválido: {escolha}");
            }
        }
    }
    
    static void TotalPontos()
    {
        int totalPontos = 0;
        for (int i = 0; i < herois.Length; i++)
        {
            if (!string.IsNullOrEmpty(herois[i].Nome))
            {
                totalPontos += herois[i].Pontuacao;
            }
        }
        Console.WriteLine($"Pontuação total da equipe: {totalPontos}");
    }
   static void ExibirEquipe()
    {
        Console.WriteLine("Exibindo equipe:");
        for (int i = 0; i < herois.Length; i++)
        {
            if (!string.IsNullOrEmpty(herois[i].Nome))
            {
                Console.WriteLine($"{herois[i].Nome} - Poder: {herois[i].Poder}, Pontuação: {herois[i].Pontuacao}");
            }
        }
        TotalPontos();
    }

    static void MenuPrincipal()
    {
        while (true)
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Cadastrar Herói");
            Console.WriteLine("2. Escolher Equipe");
            Console.WriteLine("3. Exibir Equipe");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastarHeroi();
                    break;
                case "2":
                    EscolherEquipe();
                    break;
                case "3":
                    ExibirEquipe();
                    break;
                case "4":
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Gerenciador de Heróis!");
        MenuPrincipal();
    }
}


namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Console.WriteLine("Olá! Para ver os livros disponiveis digite 1.");
            Console.WriteLine("Para adicionar um novo livro digite 2.");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {

                Console.WriteLine("Livros na biblioteca:");

                foreach (var livro in biblioteca.ListarLivro())
                {
                    livro.ExibirInfo();
                }
            }

            else if (escolha == 2)
            {   Console.WriteLine("Para adicionar um novo livro, insira algumas informações!");
                Console.WriteLine("Digite nome do livro:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite nome do autor:");
                string autor = Console.ReadLine();
                Console.WriteLine("Digite o ano de publicaçao:");
                int ano = int.Parse(Console.ReadLine());
                

                Livros novo = new Livros { Nome = nome, Autor = autor, anoPublicacao = ano };
                biblioteca.AdicionarLivro(novo);

                Console.WriteLine("Livro adicionad com sucesso!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            return;
        }
    }
}

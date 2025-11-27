namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrícula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Nota da Prova 1: ");
            double NotaProva1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota da Prova 2:");
            double NotaProva2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do Trabalho:");
            double NotaTrabalho = double.Parse(Console.ReadLine());

            alunos aluno = new alunos(matricula, nome, NotaProva1, NotaProva2, NotaTrabalho);
            double mediaa = aluno.mediaFinal();

            Console.WriteLine($"Aluno: {aluno.Nome}");
            Console.WriteLine($"Matrícula: {aluno.Matricula}");
            Console.WriteLine($"Média Final: {mediaa:F2}");

            double precisa = aluno.final();

            if (precisa == 0)
            {
                Console.WriteLine("O aluno não precisa de pontos da prova final");

            }
            else
            {

                Console.WriteLine($"O aluno precisa tirar {precisa:F2} pontos para passar");

            }
        }
    }
}

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionario funcionario = new funcionario();

            Console.WriteLine("Insira o nome do funcionario: ");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine("Agora insira o salario do funcionario: ");
            funcionario.salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dados do funcionário: " + funcionario.dadosFuncionario());
            Console.WriteLine("O salário atualizado do funcionário é: " + funcionario.aumentoSalario());
        }
    }
}

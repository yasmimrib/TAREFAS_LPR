namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            retangulo retangulo = new retangulo();

            Console.WriteLine("Insira a altura e a largura do retangulo separadas por espaço:");
            string[] valores = Console.ReadLine().Split(' ');

            retangulo.altura = Convert.ToDouble(valores[0]);
            retangulo.largura = Convert.ToDouble(valores[1]);

            Console.WriteLine("A area de retangulo é: " + retangulo.calcArea());
            Console.WriteLine("O perimetro do retangulo é: " + retangulo.calcPerimetro());
        }
    }
}


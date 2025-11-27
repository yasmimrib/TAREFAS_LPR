using System;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Olá! Para ver suas reservas futuras digite 1.");
            Console.WriteLine("Para adicionar uma nova reserva digite 2.");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                var futuras = cliente.ListarReservas();

                Console.WriteLine("\nReservas futuras:");

                if (futuras.Count == 0)
                {
                    Console.WriteLine("Nenhuma reserva futura encontrada.");
                }
                else
                {
                    foreach (var r in futuras)
                    {
                        Console.WriteLine($"Reserva {r.Id} - Data: {r.DataReserva}");
                    }
                }
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Digite o ID da reserva:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data da reserva (formato: yyyy-mm-dd):");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Reserva nova = new Reserva { Id = id, DataReserva = data };
                cliente.AdicionarReserva(nova);

                Console.WriteLine("Reserva adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            return;
        }
    }
}

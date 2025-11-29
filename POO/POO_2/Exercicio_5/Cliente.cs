using System;
using System.Collections.Generic;

namespace Exercicio_5
{
    internal class Cliente
    {
        public int Id { get; set; }
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();

        public void AdicionarReserva(Reserva reserva)
        {
            Reservas.Add(reserva);
        }

        public List<Reserva> ListarReservas()
        {
            var futuras = new List<Reserva>();

            foreach (var reserva in Reservas)
            {
                if (reserva.DataReserva > DateTime.Now)
                    futuras.Add(reserva);
            }

            return futuras;
        }
    }
}

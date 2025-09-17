using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RifaBox.Domain.Enums;

namespace RifaBox.Domain.Entities
{
    public class Ticket // cada bilhete associado a uma rifa
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public int RaffleId { get; set; } // fk para raffle, ou usar guid??
        public ETicketStatus Status { get; set; }
        public int OwnerId { get; set; } // fk para USUARIO COMPRADOR, pode ser nulo?
        public int Version { get; set; }

        private Ticket() { }

        public Ticket(int number, int raffleId)
        {

        }
    }


    // metodo para declarar se havera rifas limitadas ou ilimitadas
    // metodo para declarar a quantidade de rifas disponiveis
    // metodo que marca numeros que foram vendidos

}
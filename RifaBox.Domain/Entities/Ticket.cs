using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using RifaBox.Domain.Enums;

namespace RifaBox.Domain.Entities
{
    public class Ticket // cada bilhete associado a uma rifa
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public int RaffleId { get; set; }
        public ETicketStatus TicketStatus { get; set; }
        public int OwnerId { get; set; } // fk para USUARIO COMPRADOR, pode ser nulo?
        public int Version { get; set; }

        private Ticket() { }

        public Ticket(int number, int version)
        {
            Id = Guid.NewGuid();
            Number = number;
            TicketStatus = ETicketStatus.DISPONIVEL;
            Version = version;

        }

        public Guid MakeReservation(Guid userId)
        {
            // deve reservar o ticket para um usuário
        }

        public Guid ConfirmPurchase(Guid userId)
        {
            // deve confirmar a compra do ticket pelo usuário
        }

        public void CancelReservation()
        {
            TicketStatus = ETicketStatus.CANCELADA;
        }

        public void MarkTicketAsDraw()
        {
            TicketStatus = ETicketStatus.SORTEADO;
        }
    }


}

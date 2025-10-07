using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RifaBox.Domain.Enums;

namespace RifaBox.Domain.Entities
{
    public class Reservation // representa a reserva temporaria de bilhetes
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public List<Guid> TicketIds { get; set; } // vai virar lista, com guid?
        public DateTime ExpiresAt { get; set; }
        public EReservationStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsPaymentConfirmed { get; set; } // p simular pagamento
        public DateTime? ConfirmedAt { get; set; }

        private Reservation() { }

        public Reservation()
        {

        }

        public void AdicionarTicketAReserva(Ticket ticket)
        {

        }

        public void RemoverTicketDaReserva(Ticket ticket)
        {

        }

        public void ConfirmReservation()
        {
            // confirma reserva, mudando sey status
        }

        public void CancelReservation()
        {
            // vai cancelar a reserva, e libera os tickets
        }

        public void VerificarExpiracaoDeReserva()
        {
            // vai verificar se a reserva expirou e a cancela automaticamnte
        }

    }
}
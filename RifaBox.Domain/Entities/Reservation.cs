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
        public bool IsConfirmed { get; set; } // p simular pagamento
        public DateTime? ConfirmedAt { get; set; }
        
        /*
        adicionarticket
        confirmar
        cancelar
        verificarexpiracao
        */
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RifaBox.Domain.Entities
{
    public class Reservation // representa a reserva temporaria de bilhetes
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int TicketIds { get; set; } // vai virar lista, com guid?
        public DateTime ExpiresAt { get; set; }
        public string Status { get; set; } // vai virar enum: pending, expired, confirmed
        public DateTime CreatedAt { get; set; }
        public bool IsConfirmed { get; set; } // p simular pagamento
        public DateTime? ConfirmedAt { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RifaBox.Domain.Entities
{
    public class Draw // armazena informações do sorteio de uma rifa
    {
        public Guid Id { get; set; }
        public int RaffleId { get; set; } // ou guid?
        public string Seed { get; set; }
        public string Algorithm { get; set; }
        public string Winners { get; set; } // lista com guid fk??
        public DateTime CreatedAt { get; set; }

        /*
        
        executar sorteio
        registarvencedor
        validarresultado
        */
    }
}
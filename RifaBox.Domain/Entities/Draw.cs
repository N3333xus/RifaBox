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
        public string Seed { get; set; } // depois implementar algoritmo para gerar seed e seedhash
        public string Algorithm { get; set; }
        public List<Guid> WinnersList { get; set; }
        public DateTime CreatedAt { get; set; }

        private Draw() { }

        public Draw()
        {
            Id = Guid.NewGuid();

            CreatedAt = DateTime.UtcNow;
        }

        public void ExecutarSorteio()
        {

        }

        public void RegistarTickeDotVencedor(Ticket ticket)
        {

        }

        public void ValidarResultadoDoSorteio(string seed)
        {


        }
    }
}
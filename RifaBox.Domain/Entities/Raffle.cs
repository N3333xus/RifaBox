using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RifaBox.Domain.Enums;


namespace RifaBox.Domain.Entities
{
    public class Raffle // é a raiz do agregate, controla bilhetes, reservas e sorteios
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string RaffleImages { get; set; }
        public decimal TicketPrices { get; set; }
        public decimal TotalTickets { get; set; } // ou sem limite
        public decimal DrawRate { get; set; }
        public ERaffleStatus RaffleStatus { get; set; }
        public int SeedHash { get; set; }
        public DateTime CreatedAt { get; set; }

        /*
        Ativar() → muda status de draft para active.
        Encerrar() → muda status de active para closed.
        IniciarSorteio(seed, algoritmo) → cria um Draw.
        AdicionarImagem(RaffleImage)
        GerarBilhetes(totalTickets) ou AdicionarBilhete(Ticket)
        AlterarPreco(decimal novoValor) (restrição: só se estiver em draft).
        */
    }
}
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
        public string RaffleImages { get; set; } // caminho p imagem da rifa, usar lista de string,? ver melhor essa questão
        public decimal TicketPrices { get; set; }
        public int? TotalTickets { get; set; } // pode ser nulo para ilimitado
        public decimal DrawRate { get; set; }
        public ERaffleStatus RaffleStatus { get; set; } // draft, active, closed, drawn
        public string SeedHash { get; set; }
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
using RifaBox.Domain.Enums;


namespace RifaBox.Domain.Entities
{
    public class Raffle // o evento
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string RaffleImages { get; set; } // caminho p imagem da rifa, usar lista de string,? ver melhor essa questão
        public decimal TicketPrices { get; set; }
        public int? TotalTickets { get; set; } // pode ser nulo para ilimitado
        public decimal DrawRate { get; set; }
        public ERaffleStatus RaffleStatus { get; set; }
        public string SeedHash { get; set; }
        public DateTime CreatedAt { get; set; }

        private Raffle() { }

        public Raffle(string name, string description, decimal ticketPrices, int totalTickets, decimal drawRate, string seedHash)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            //ver questão de imagem
            TicketPrices = ticketPrices;
            TotalTickets = totalTickets;
            DrawRate = drawRate;
            RaffleStatus = ERaffleStatus.RASCUNHO;
            SeedHash = seedHash;
            CreatedAt = DateTime.UtcNow;

        }

        public void ActivateRaffle()
        {
            RaffleStatus = ERaffleStatus.ATIVA;
        }

        public void EndRaffle()
        {
            RaffleStatus = ERaffleStatus.FINALIZADA;
        }

        /*
    AdicionarTicket(Ticket ticket): Adiciona um ticket à rifa.

    RemoverTicket(Ticket ticket): Remove um ticket da rifa.

    IniciarSorteio(): Muda o status da rifa para "Em Sorteio".

    FinalizarSorteio(): Finaliza o sorteio da rifa.

    CancelarRifa(): Cancela a rifa.

    AdicionarPremio(string premio): Adiciona um prêmio à rifa (se houver múltiplos prêmios).
        */
    }
}
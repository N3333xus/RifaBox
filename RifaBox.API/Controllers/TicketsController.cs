using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

/* Controller de gestão de tickets
endpoints:
    GET /api/tickets/available/{raffleId} - listar Tickets disponíveis
    GET /api/tickets/my-tickets - listar tickets do usuario logado
    POST /api/tickets/reserve - Reservar tickets
    POST /api/tickets/{reservationId}/confirm - Confirmar reserva de tcikets
    DELETE /api/tickets/reservation/{id} - Cancelar reserva
    GET /api/tickets/{id} - obter Detalhes do ticket

*/

namespace RifaBox.API.Controllers
{
    [Route("[controller]")]
    public class TicketsController : Controller
    {
        private readonly ILogger<TicketsController> _logger;

        public TicketsController(ILogger<TicketsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
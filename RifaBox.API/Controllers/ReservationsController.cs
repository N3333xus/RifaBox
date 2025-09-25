using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/* controller de gestão de reservas
endpoints
    GET /api/reservations - listar reservas do usuario
    GET /api/reservations/{id} - obter Detalhes de uma reserva
    PUT /api/reservations/{id}/confirm - Confirmar reserva
    POST /api/reservations - Criar nova reserva?
    DELETE /api/reservations/{id} - Cancelar reserva
    GET /api/reservations/expired - listar Reservas expiradas
*/

namespace RifaBox.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationsController : ControllerBase
    {

    }
}
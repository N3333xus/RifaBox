using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/* controller de administração
endpoints:
    GET /api/admin/users - Gerenciar usuários (apenas admin)
    PUT /api/admin/users/{id}/role - Alterar role de user (apenas admin)
    GET /api/admin/raffles - listar Todas as rifas (apenas admin)
    GET /api/admin/reservations - listar Todas as reservas (apenas admin)
*/

namespace RifaBox.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {

    }
}
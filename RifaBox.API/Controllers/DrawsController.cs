using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/* controller de sorteios e resultados
endpoints:
    GET /api/draws/{raffleId} - obter Resultado do sorteio
    GET /api/draws/history - Histórico de sorteios
    POST /api/draws/validate - Validar resultado de sorteio
*/

namespace RifaBox.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrawsController : ControllerBase
    {

    }
}
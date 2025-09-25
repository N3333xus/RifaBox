using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/*controller de relatorios e estatisticas
endpoints:

    GET /api/reports/raffles/{id}/summary - relatorio resumido da rifa
    GET /api/reports/sales - Relatório de vendas (admin)
    GET /api/reports/user-activity - relatorio de atividade usuarios(apenas admin)
    GET /api/stats/raffles-popular - estatisticas de Rifas populares
*/

namespace RifaBox.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {

    }
}
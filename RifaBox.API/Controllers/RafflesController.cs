using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Controller de gestão de rifas
endpoints:
    GET /api/raffles - Listar rifas com filtros
    GET /api/raffles/{id} - Obter detalhes de rifa especifica
    POST /api/raffles - Criar nova rifa (organizador e admin)
    PUT /api/raffles/{id} - Atualizar rifa (organizador e admin)
    DELETE /api/raffles/{id} - Excluir rifa (organizador e admin)
    PUT /api/raffles/{id}/status - Alterar status
    GET /api/raffles/{id}/tickets - Listar tickets de uma rifa
    POST /api/raffles/{id}/draw - Realizar sorteio (apenas organizador e admin)
*/

namespace RifaBox.API.Controllers
{
    public class RafflesController
    {

    }
}
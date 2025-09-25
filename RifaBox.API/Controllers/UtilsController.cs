using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/* controller de utilitarios
endpoints:
    GET /api/health - Status da API
    GET /api/version - Versão da API
*/

namespace RifaBox.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UtilsController : ControllerBase
    {

    }
}
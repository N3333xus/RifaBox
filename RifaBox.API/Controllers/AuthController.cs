using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RifaBox.Infra.DataBase.Repositories;

using Microsoft.AspNetCore.Mvc;

/*
Controller de autenticação
ENDPOINTS
    POST /api/auth/register - Registrar usuário
    POST /api/auth/login - Login e obter token jwt
    GET /api/auth/me - Obter info usuário atual
*/

namespace RifaBox.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {

    }
}
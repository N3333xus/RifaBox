using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using RifaBox.Domain.Entities;
using RifaBox.Infra.DataBase.Repositories;

namespace RifaBox.API.Controllers
{
    [ApiController] // controller de autenticação
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {

        [HttpPost("register")] // POST /api/auth/register - Registrar usuário
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDto)
        {

        }

        [HttpPost("login")] //POST /api/auth/login - Login e obter token jwt
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDto)
        {

        }

        [HttpGet("me")] //GET /api/auth/me - Obter info usuário atual
        public IActionResult GetCurrentUserInfo()
        {

        }

        pivate string JwtTokenGenerator(User user)
        {
            // lógica para geração de token
        }
    }
}
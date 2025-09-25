using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

/* Controller de gestão de users
endpoints:
    PUT /api/users/{id}/profile - Atualizar perfil de usuario
    PUT /api/users/{id}/password - Alterar senha
    PUT /api/users/{id}/deactivate - Desativar conta
    PUT /api/users/{id}/activate - Reativar conta
*/

namespace RifaBox.API.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
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
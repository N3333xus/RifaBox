using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RifaBox.Application.Interfaces.Auth;
using RifaBox.Application.DTOs;
using RifaBox.Domain.Interfaces.Repositories;
//using RifaBox.Infra.Auth;

namespace RifaBox.Application.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IIdentityService _identityService;
        private readonly IJwtTokenService _jwtTokenService;
        
    }
}
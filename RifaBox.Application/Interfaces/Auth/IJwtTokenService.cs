using RifaBox.Application.DTOs.Auth;
using System.Security.Claims;

namespace RifaBox.Application.Interfaces.Auth
{
    public interface IJwtTokenService
    {
        public string GenerateToken(AuthResultDto user, IEnumerable<string> roles);
        public string GenerateRefreshToken();
        public string ValidateToken(string token);

        // refreshtokenasync
        //revoketokenascyn
    }
}
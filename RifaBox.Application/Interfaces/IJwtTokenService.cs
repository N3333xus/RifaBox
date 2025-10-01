using RifaBox.Application.DTOs.Auth;

namespace RifaBox.Application.Interfaces
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
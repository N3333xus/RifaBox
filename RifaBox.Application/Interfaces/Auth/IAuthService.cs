using RifaBox.Application.DTOs.Auth;

namespace RifaBox.Application.Interfaces.Auth
{
    public interface IAuthService
    {
        public Task<AuthResultDto> RegisterAsync(RegisterDto registerDto);
        public Task<AuthResultDto> LoginAsync(LoginDto loginDto);
        public Task<AuthResultDto> RefreshTokenAsync(string token, string refreshToken);

        public Task<bool> LogoutAsync(string userId);
        public Task<bool> RevokeTokenAsync(string userId);

        // sera necessários?: 
            // changepassword
            // RequestPaswordResed
            // resetpassword
            // validatetoken

    }
}
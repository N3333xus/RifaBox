namespace RifaBox.Application.DTOs.Auth
{
    public class AuthResultDto
    {
        public bool Success { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        //public List<string>Roles { get; set; }OBS:LEMBRAR DISSO AQUI
        public string Email { get; set; }
        //public DateTime TokenExpiry { get; set; } ver se faz sentido implementação!
        public string ErrorMessage { get; set; }

        public static AuthResultDto AuthSuccess(string token, string refreshtoken, Guid userId, string userName, string email)
        {
            return new AuthResultDto
            {
                Success = true,
                Token = token,
                RefreshToken = refreshtoken,
                UserId = userId,
                UserName = userName,
                Email = email,
                //TokenExpiry = DateTime.UtcNow.AddHours(1)
            };
        }

        public static AuthResultDto AuthFailure(string errorMessage)
        {
            return new AuthResultDto
            {
                Success = false,
                ErrorMessage = errorMessage,
                //Roles = new List<string>()
            };
        }
    }
}


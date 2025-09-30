namespace RifaBox.Application.DTOs
{
    public class AuthResult
    {
        public bool Success { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ErrorMessage { get; set; }

        public static AuthResult AuthSuccess(string token, string refreshtoken, Guid userId, string userName, string email)
        {
            return new AuthResult
            {
                Success = true,
                Token = token,
                RefreshToken = refreshtoken,
                UserId = userId,
                UserName = userName,
                Email = email
            };
        }

        public static AuthResult AuthFailure(string errorMessage)
        {
            return new AuthResult
            {
                Success = false,
                ErrorMessage = errorMessage
            };
        }
    }
}
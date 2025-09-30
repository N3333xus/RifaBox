using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RifaBox.Application.Interfaces
{
    public interface IJwtTokenService
    {
        //public string GenerateToken(IdentityUser, identityUser, IEnumerable<string> roler);
        public string GenerateRefreshToken();
        public string ValidateToken(string token);
    }
}
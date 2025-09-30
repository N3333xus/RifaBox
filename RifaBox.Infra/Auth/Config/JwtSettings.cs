using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RifaBox.Infra.Identity.Config
{
    public class JwtSettings
    {
        public string ValidIssuer { get; set; } = string.Empty;
        public string ValidAudience { get; set; } = string.Empty;
        public string SecretKey { get; set; } = string.Empty;
        public int ExpiryMinutes { get; set; }
    }
}
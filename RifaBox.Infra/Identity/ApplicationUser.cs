using Microsoft.AspNetCore.Identity;

namespace RifaBox.Infra.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        //autenticação (login e senha)
        //autorização (roles e claims)
    }
}
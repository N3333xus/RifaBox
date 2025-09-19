using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace RifaBox.Infra.DataBase;

public class RifaBoxDbContext : IdentityDbContext<IdentityUser>
{
    public RifaBoxDbContext(DbContextOptions<RifaBoxDbContext> options) :
        base(options)
    { }

    // configurar o contexto
    // configurar as roles e graus de acesso
    // adicionar o servico do identity ao container
    // ativar APIs do identity
    // mapear rotas do identity
    // deixar os endpoints selecionados

    // usar token-based authentication
}

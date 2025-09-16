// using Microsoft.AspNetCore.Identity;
// VER APLICAÇÃO DE IDENTITY PARA  O PROJETO
namespace RifaBox.Domain.Entities;

public class User // : IdentityUser<Guid> // representa pessoas no sistema, com papeis diferentes
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public int Role { get; set; } // ADMIN, MODERADOR, organizadorSorteio, ParticipanteSorteio

    private User() { }

    public User(string name, string email, string passwordHash)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = passwordHash;

    }

    public void AlterarSenha(string newPasswordHash)
    {
        PasswordHash = newPasswordHash;
    }

    public void AtualizarPerfil(string newName, string newEmail)
    {
        Name = newName;
        Email = newEmail;
    }

    // DesativarConta
    // AtivarConta       
}

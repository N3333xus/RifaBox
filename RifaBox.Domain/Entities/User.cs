namespace RifaBox.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    //public string PasswordHash { get; set; }
    public int Role { get; set; } // ADMIN, MODERADOR, organizadorSorteio, ParticipanteSorteio
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }

    private User() { }

    public User(string name, string email/*, string passwordHash*/)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        //PasswordHash = passwordHash;
        IsActive = true;
        CreatedAt = DateTime.UtcNow;

    }

    /*public void UpdatePassword(string newPasswordHash)
    {
        PasswordHash = newPasswordHash;
    }*/

    public void UpdateProfile(string newName, string newEmail)
    {
        Name = newName;
        Email = newEmail;
    }

    public void DeactivateAcount()
    {
        IsActive = false;
    }

    public void ActivateAccount()
    {
        IsActive = true;
    }    
}

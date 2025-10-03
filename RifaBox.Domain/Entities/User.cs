namespace RifaBox.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    //public string PasswordHash { get; set; }
    public int Role { get; set; } // ADMIN, MODERADOR, organizadorSorteio, ParticipanteSorteio
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }

    private User() { }

    public User(string userName, string email/*, string passwordHash*/)
    {
        Id = Guid.NewGuid();
        UserName = userName;
        Email = email;
        //PasswordHash = passwordHash;
        IsActive = true;
        CreatedAt = DateTime.UtcNow;

    }

    /*public void UpdatePassword(string newPasswordHash) 
    {
        PasswordHash = newPasswordHash;
    }*/

    public void UpdateProfile(string newUserName, string newEmail)
    {
        UserName = newUserName;
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

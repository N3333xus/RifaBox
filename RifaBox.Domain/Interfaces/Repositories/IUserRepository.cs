using RifaBox.Domain.Entities;

namespace RifaBox.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    // get
    public Task<IEnumerable<User>> GetAllAsync();
    public Task<User?> GetByIdAsync(Guid id);
    public Task<User> GetByEmailAsync(string email);
    public Task<bool> ExistsAsync(Guid id);
    public Task<bool> ExistsByEmailAsync(string email);
    public Task<IEnumerable<User>> GetAllOrganizersAsync();
    public Task<int> GetTotalUsersCountAsync();
    

    public Task<User> AddAsync(User user); //create
    public Task<User> UpdateAsync(User user); //update

    public Task DeleteAsync(User user); // DELETE
}
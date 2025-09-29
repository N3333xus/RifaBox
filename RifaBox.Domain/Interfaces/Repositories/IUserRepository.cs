using RifaBox.Domain.Entities;

namespace RifaBox.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    public Task<IEnumerable<User?>> GetAllAsync();
    public Task<User> GetByIdAsync(Guid id);
    public Task<User> AddAsync(User user);
    public Task<User> UpdateAsync(User user);
    public Task<User> DeleteAsync(Guid id);
}

using UsersManagement.Shared.Models;

namespace UsersManagement.Client.UserRepository
{
    public interface IUserRepository
    {
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<User> DeleteUserAsync(int userId);
        Task<List<User>> GetAllUsersAsync();

        Task<User> GetUsersByIdAsync(int userId);
    }
}

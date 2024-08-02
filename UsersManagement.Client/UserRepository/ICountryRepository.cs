using UsersManagement.Shared.Models;

namespace UsersManagement.Client.UserRepository
{
    public interface ICountryRepository
    {
        Task<Country> AddAsync(Country mod);
        Task<Country> UpdateAsync(Country mod);
        Task<Country> DeleteAsync(int userId);
        Task<List<Country>> GetAllAsync();

        Task<Country> GetByIdAsync(int userId);
    }
}

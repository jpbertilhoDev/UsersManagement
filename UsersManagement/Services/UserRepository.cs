using Microsoft.EntityFrameworkCore;
using UsersManagement.Data;
using UsersManagement.Shared.Models;
using UsersManagement.Shared.UserRepository;

namespace UsersManagement.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) 
        { 
            this._context = context;
        
        }

        public async Task<User> AddUserAsync(User user)
        {
            if (user == null) return null;


            var newsUser = _context.users.Add(user).Entity;
            await _context.SaveChangesAsync();

            return newsUser; 
        }

        public async Task<User> DeleteUserAsync(int userId)
        {
            var user = await _context.users.Where(x => x.Id == userId).FirstOrDefaultAsync();
            if (user == null) return null;

            _context.users.Remove(user);
            await _context.SaveChangesAsync();

            return user;

        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var users = await _context.users.ToListAsync();

            return users;
        }

        public async Task<User?> GetUsersByIdAsync(int userId)
        {
            var singlesUser = _context.users.Where(x => x.Id == userId).FirstOrDefaultAsync();
            if (singlesUser == null) return null;

            return await singlesUser;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            if (user == null) return null;

            var newsUser = _context.users.Update(user).Entity;
            await _context.SaveChangesAsync();

            return newsUser;

        }
    }
}

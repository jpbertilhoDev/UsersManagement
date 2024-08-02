using System.Net.Http.Json;
using UsersManagement.Shared.Models;
using UsersManagement.Client.UserRepository;

namespace UsersManagement.Client.Services
{
    public class UserService : IUserRepository
    {

        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<User> AddUserAsync(User user)
        {
            var newsuser = await _httpClient.PostAsJsonAsync("api/User/Add-User", user);
            var response = await newsuser.Content.ReadFromJsonAsync<User>();

            return response;

        }

        public async Task<User> DeleteUserAsync(int userId)
        {
            var newsuser = await _httpClient.PostAsJsonAsync("api/User/Delete-User", userId);
            var response = await newsuser.Content.ReadFromJsonAsync<User>();

            return response;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var allusers = await _httpClient.GetAsync("api/User/All-Users");
            var response = await allusers.Content.ReadFromJsonAsync<List<User>>();

            return response;
        }

        public async Task<User> GetUsersByIdAsync(int userId)
        {
            var singleusers = await _httpClient.GetAsync("api/User/Single-Users");
            var response = await singleusers.Content.ReadFromJsonAsync<User>();

            return response;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            var newsuser = await _httpClient.PostAsJsonAsync("api/User/Update-User", user);
            var response = await newsuser.Content.ReadFromJsonAsync<User>();

            return response;
        }
    }
}

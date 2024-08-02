using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersManagement.Shared.Models;
using UsersManagement.Client.UserRepository;

namespace UsersManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository) 
        { 
            this._userRepository = userRepository;
        }

        [HttpGet("All-Users")]

        public async Task<ActionResult<List<User>>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();

            return Ok(users);
        }
        
        [HttpGet("Single-Users/{id}")]

        public async Task<ActionResult<User>> GetSinglesUserAsync(int id)
        {
            var user = await _userRepository.GetUsersByIdAsync(id);

            return Ok(user);
        }

        [HttpPost("Add-User")]

        public async Task<ActionResult<User>> AddNewSinglesUsersAsync(User user)
        {
            var newUser = await _userRepository.AddUserAsync(user);

            return Ok(newUser);
        }

        [HttpPost("Delete-User/{id}")]

        public async Task<ActionResult<User>> DeleteUserAsync(int id)
        {
            var deleteuser = await _userRepository.DeleteUserAsync(id);

            return Ok(deleteuser);
        }

        [HttpPost("Update-User")]

        public async Task<ActionResult<User>> UpdateUsersAsync(User user)
        {
            var updateUser = await _userRepository.UpdateUserAsync(user);

            return Ok(updateUser);
        }
    }
}

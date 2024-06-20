using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MypulseWebapi.Dtos.User;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            var users = await _userRepository.GetAllAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }


        [HttpGet("minimal/{id}")]
        public async Task<ActionResult<MinimalUserDto>> GetMinimalUserById(string id)
        {
            var userDto = await _userRepository.GetAsync(
                u => u.Id == id,
                u => new MinimalUserDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    Description = u.Description
                });

            if (userDto == null)
            {
                return NotFound();
            }

            return Ok(userDto);
        }

        [HttpGet("minimaldetailed/{id}")]
        public async Task<ActionResult<MinimalDetailedUser>> GetMinimalDetailedUserById(string id)
        {
            var userDto = await _userRepository.GetAsync(
                u => u.Id == id,
                u => new MinimalDetailedUser
                {
                    Id = u.Id,
                    Name = u.Name,
                    Description = u.Description,
                    DateOfBirth = u.DateOfBirth,
                    Phone_Number = u.Phone_Number
                });

            if (userDto == null)
            {
                return NotFound();
            }

            return Ok(userDto);
        }


        [HttpGet("/valcheck")]
        public bool GetValue([FromQuery] string[] user1, [FromQuery] string[] user2)
        {
            // Check if either array is null
            if (user1 == null || user2 == null)
            {
                return false;
            }

            // Sort both arrays
            var sortedUser1 = user1.OrderBy(x => x).ToArray();
            var sortedUser2 = user2.OrderBy(x => x).ToArray();

            // Check if both arrays have the same elements in any order
            return sortedUser1.SequenceEqual(sortedUser2);
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _userRepository.AddAsync(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] User user)
        {
            Console.WriteLine($"Updating user: {user.Id}");
            if (id != user.Id)
            {
                return BadRequest("ID mismatch");
            }

            if (!await _userRepository.Exists(id))
            {
                return NotFound($"User with ID {id} not found.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _userRepository.UpdateAsync(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating user: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            if (!await _userRepository.Exists(id))
            {
                return NotFound();
            }

            await _userRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}

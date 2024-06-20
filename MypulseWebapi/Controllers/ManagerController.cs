using Microsoft.AspNetCore.Mvc;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MypulseWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManagerRepository _managerRepository;

        public ManagerController(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }

        // Example of using the repository in an action
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manager>>> GetAllManagers()
        {
            var managers = await _managerRepository.GetAllAsync();
            return Ok(managers);
        }

        // GET: api/Manager/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Manager>> GetManager(string id)
        {
            var manager = await _managerRepository.GetByIdAsync(id);

            if (manager == null)
            {
                return NotFound();
            }

            return Ok(manager);
        }

        // POST: api/Manager
        [HttpPost]
        public async Task<ActionResult<Manager>> CreateManager([FromBody] Manager manager)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _managerRepository.AddAsync(manager);
            return CreatedAtAction(nameof(GetManager), new { id = manager.Id }, manager);
        }

        // PUT: api/Manager/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateManager(string id, [FromBody] Manager manager)
        {
            if (id != manager.Id)
            {
                return BadRequest();
            }

            if (!await _managerRepository.Exists(id))
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _managerRepository.UpdateAsync(manager);

            return NoContent();
        }

        // DELETE: api/Manager/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManager(string id)
        {
            if (!await _managerRepository.Exists(id))
            {
                return NotFound();
            }

            await _managerRepository.DeleteAsync(id);

            return NoContent();
        }
    }
}

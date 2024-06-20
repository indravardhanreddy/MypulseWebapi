using Microsoft.AspNetCore.Mvc;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Controllers
{
    [Route("api/entityManager/[controller]")]
    [ApiController]
    public class EntityManagerController : ControllerBase
    {
        private readonly IEntityManagerRepository _entityManagerRepository;

        public EntityManagerController(IEntityManagerRepository entityManagerRepository)
        {
            _entityManagerRepository = entityManagerRepository;
        }

        // GET: api/EntityManager
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntityManager>>> GetAllEntityManagers()
        {
            var entityManagers = await _entityManagerRepository.GetAllAsync();
            return Ok(entityManagers);
        }

        // GET: api/EntityManager/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntityManager>> GetEntityManager(string id)
        {
            var entityManager = await _entityManagerRepository.GetByIdAsync(id);

            if (entityManager == null)
            {
                return NotFound("EntityManager not found");
            }

            return Ok(entityManager);
        }

        // POST: api/EntityManager
        [HttpPost]
        public async Task<ActionResult<EntityManager>> CreateEntityManager([FromBody] EntityManager entityManager)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _entityManagerRepository.AddAsync(entityManager);
            return CreatedAtAction(nameof(GetEntityManager), new { id = entityManager.Id }, entityManager);
        }

        // PUT: api/EntityManager/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEntityManager(string id, [FromBody] EntityManager entityManager)
        {
            if (id != entityManager.Id)
            {
                return BadRequest("EntityManager ID mismatch");
            }

            if (!await _entityManagerRepository.Exists(id))
            {
                return NotFound("EntityManager not found");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _entityManagerRepository.UpdateAsync(entityManager);

            return NoContent(); // 204 No Content
        }

        // DELETE: api/EntityManager/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntityManager(string id)
        {
            if (!await _entityManagerRepository.Exists(id))
            {
                return NotFound("EntityManager not found");
            }

            await _entityManagerRepository.DeleteAsync(id);

            return NoContent(); // 204 No Content
        }
    }
}

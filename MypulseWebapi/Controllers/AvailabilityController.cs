using Microsoft.AspNetCore.Mvc;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        private readonly IAvailabilityRepository _availabilityRepository;

        public AvailabilityController(IAvailabilityRepository availabilityRepository)
        {
            _availabilityRepository = availabilityRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Availability>>> GetAllAvailabilitys()
        {
            var availabilities = await _availabilityRepository.GetAllAsync();
            return Ok(availabilities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Availability>> GetAvailability(string id)
        {
            var availability = await _availabilityRepository.GetByIdAsync(id);
            if (availability == null)
            {
                return NotFound();
            }
            return Ok(availability);
        }

        [HttpPost]
        public async Task<ActionResult<Availability>> CreateAvailability([FromBody] Availability availability)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _availabilityRepository.AddAsync(availability);
            return CreatedAtAction(nameof(GetAvailability), new { id = availability.Id }, availability);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAvailability(string id, [FromBody] Availability availability)
        {
            if (id != availability.Id)
            {
                return BadRequest();
            }

            if (!await _availabilityRepository.Exists(id))
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _availabilityRepository.UpdateAsync(availability);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAvailability(string id)
        {
            if (!await _availabilityRepository.Exists(id))
            {
                return NotFound();
            }

            await _availabilityRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}

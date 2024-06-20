using Microsoft.AspNetCore.Mvc;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfigurationRepository _configurationRepository;

        public ConfigurationController(IConfigurationRepository configurationRepository)
        {
            _configurationRepository = configurationRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Configuration>>> GetAllConfigurations()
        {
            var configurations = await _configurationRepository.GetAllAsync();
            return Ok(configurations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Configuration>> GetConfiguration(string id)
        {
            var configuration = await _configurationRepository.GetByIdAsync(id);
            if (configuration == null)
            {
                return NotFound();
            }
            return Ok(configuration);
        }

        [HttpPost]
        public async Task<ActionResult<Configuration>> CreateConfiguration([FromBody] Configuration configuration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _configurationRepository.AddAsync(configuration);
            return CreatedAtAction(nameof(GetConfiguration), new { id = configuration.Id }, configuration);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateConfiguration(string id, [FromBody] Configuration configuration)
        {
            if (id != configuration.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _configurationRepository.UpdateAsync(configuration);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfiguration(string id)
        {
            if (!await _configurationRepository.Exists(id))
            {
                return NotFound();
            }

            await _configurationRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}

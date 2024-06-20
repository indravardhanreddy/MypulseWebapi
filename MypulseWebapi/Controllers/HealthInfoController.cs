using Microsoft.AspNetCore.Mvc;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthInfoController : ControllerBase
    {
        private readonly IHealthInfoRepository _healthInfoRepository;

        public HealthInfoController(IHealthInfoRepository healthInfoRepository)
        {
            _healthInfoRepository = healthInfoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HealthInfo>>> GetAllHealthInfos()
        {
            var healthInfos = await _healthInfoRepository.GetAllAsync();
            return Ok(healthInfos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HealthInfo>> GetHealthInfo(string id)
        {
            var healthInfo = await _healthInfoRepository.GetByIdAsync(id);
            if (healthInfo == null)
            {
                return NotFound();
            }
            return Ok(healthInfo);
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<HealthInfo>> GetHealthInfoByUser(string userId)
        {
            var healthInfo = await _healthInfoRepository.GetByUserIdAsync(userId);
            if (healthInfo == null)
            {
                return NotFound();
            }
            return Ok(healthInfo);
        }

        [HttpPost]
        public async Task<ActionResult<HealthInfo>> CreateHealthInfo([FromBody] HealthInfo healthInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _healthInfoRepository.AddAsync(healthInfo);
            return CreatedAtAction(nameof(GetHealthInfo), new { id = healthInfo.Id }, healthInfo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHealthInfo(string id, [FromBody] HealthInfo healthInfo)
        {
            if (id != healthInfo.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _healthInfoRepository.UpdateAsync(healthInfo);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHealthInfo(string id)
        {
            if (!await _healthInfoRepository.Exists(id))
            {
                return NotFound();
            }

            await _healthInfoRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}

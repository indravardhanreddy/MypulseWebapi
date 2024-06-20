using Microsoft.AspNetCore.Mvc;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseController : ControllerBase
    {
        private readonly ILicenseRepository _licenseRepository;

        public LicenseController(ILicenseRepository licenseRepository)
        {
            _licenseRepository = licenseRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<License>>> GetAllLicenses()
        {
            var licenses = await _licenseRepository.GetAllAsync();
            return Ok(licenses);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<License>> GetLicense(string id)
        {
            var license = await _licenseRepository.GetByIdAsync(id);
            if (license == null)
            {
                return NotFound();
            }
            return Ok(license);
        }

        [HttpPost]
        public async Task<ActionResult<License>> CreateLicense([FromBody] License license)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _licenseRepository.AddAsync(license);
            return CreatedAtAction(nameof(GetLicense), new { id = license.Id }, license);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLicense(string id, [FromBody] License license)
        {
            if (id != license.Id)
            {
                return BadRequest();
            }

            if (!await _licenseRepository.Exists(id))
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _licenseRepository.UpdateAsync(license);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLicense(string id)
        {
            if (!await _licenseRepository.Exists(id))
            {
                return NotFound();
            }

            await _licenseRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatSessionController : ControllerBase
    {
        private readonly IChatSessionRepository _chatSessionRepository;

        public ChatSessionController(IChatSessionRepository chatSessionRepository)
        {
            _chatSessionRepository = chatSessionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChatSession>>> GetAllChatSessions()
        {
            var chatSessions = await _chatSessionRepository.GetAllAsync();
            return Ok(chatSessions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ChatSession>> GetChatSession(string id)
        {
            var chatSession = await _chatSessionRepository.GetByIdAsync(id);
            if (chatSession == null)
            {
                return NotFound();
            }
            return Ok(chatSession);
        }

        [HttpPost]
        public async Task<ActionResult<ChatSession>> CreateChatSession([FromBody] ChatSession chatSession)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _chatSessionRepository.AddAsync(chatSession);
            return CreatedAtAction(nameof(GetChatSession), new { id = chatSession.Id }, chatSession);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateChatSession(string id, [FromBody] ChatSession chatSession)
        {
            if (id != chatSession.Id)
            {
                return BadRequest();
            }

            if (!await _chatSessionRepository.Exists(id))
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _chatSessionRepository.UpdateAsync(chatSession);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChatSession(string id)
        {
            if (!await _chatSessionRepository.Exists(id))
            {
                return NotFound();
            }

            await _chatSessionRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}

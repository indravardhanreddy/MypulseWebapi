using Microsoft.AspNetCore.Mvc;
using MypulseWebapi.interfaces;
using MypulseWebapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MypulseWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetAllMessages()
        {
            var messages = await _messageRepository.GetAllAsync();
            return Ok(messages);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Message>> GetMessage(string id)
        {
            var message = await _messageRepository.GetByIdAsync(id);
            if (message == null)
            {
                return NotFound();
            }
            return Ok(message);
        }

        [HttpGet("session/{chatSessionId}")]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessagesByChatSession(string chatSessionId)
        {
            var messages = await _messageRepository.GetByChatSessionIdAsync(chatSessionId);
            return Ok(messages);
        }

        [HttpPost]
        public async Task<ActionResult<Message>> CreateMessage([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _messageRepository.AddAsync(message);
            return CreatedAtAction(nameof(GetMessage), new { id = message.Id }, message);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMessage(string id, [FromBody] Message message)
        {
            if (id != message.Id)
            {
                return BadRequest();
            }

            await _messageRepository.UpdateAsync(message);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(string id)
        {
            await _messageRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}

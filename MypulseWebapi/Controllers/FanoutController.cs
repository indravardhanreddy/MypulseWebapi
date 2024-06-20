using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MypulseWebapi.Services;

namespace MypulseWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FanoutController : ControllerBase
    {
        private readonly RabbitMQService _rabbitMQService;

        public FanoutController(RabbitMQService rabbitMQService)
        {
            _rabbitMQService = rabbitMQService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] string message)
        {
            _rabbitMQService.Publish(message);
            return Ok();
        }

        [HttpGet("start-consumer")]
        public ActionResult StartConsumer()
        {
            _rabbitMQService.StartConsumer();
            return Ok("Consumer started");
        }

    }
}

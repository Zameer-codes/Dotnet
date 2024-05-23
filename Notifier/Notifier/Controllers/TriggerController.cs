using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notifier.Events;
using Notifier.PubSub;

namespace Notifier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriggerController : ControllerBase
    {
        private readonly Publisher _publisher;

        public TriggerController(Publisher publisher)
        {
            _publisher = publisher;
        }

        [HttpPost("trigger")]
        public IActionResult PubSub()
        {
            _publisher.GenerateData();
            return Ok("Event triggered: User created");
        }

        [HttpGet("clickbutton")]
        public void Events()
        {
            TriggerEvent.RequestedToTriggerEvent();
        }
    }
}

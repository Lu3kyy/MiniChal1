using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpGet("intro")]
        public IActionResult Intro([FromQuery] string name, [FromQuery] string wakeTime)
        {
            var result = _service.GetIntro(name, wakeTime);
            return Ok(result);
        }
    }
}

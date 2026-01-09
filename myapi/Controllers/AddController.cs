using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddController : ControllerBase
    {
        private readonly IAddService _service;

        public AddController(IAddService service)
        {
            _service = service;
        }

        [HttpGet("add")]
        public IActionResult Add([FromQuery] int a, [FromQuery] int b)
        {
            var result = _service.GetSum(a, b);
            return Ok(result);
        }
    }
}

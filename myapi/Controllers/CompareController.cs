using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompareController : ControllerBase
    {
        private readonly ICompareService _service;

        public CompareController(ICompareService service)
        {
            _service = service;
        }

        [HttpGet("compare")]
        public IActionResult Compare([FromQuery] int a, [FromQuery] int b)
        {
            var (s1, s2) = _service.GetComparisons(a, b);
            return Ok(new { Statement1 = s1, Statement2 = s2 });
        }
    }
}

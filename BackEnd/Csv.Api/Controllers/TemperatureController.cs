using Csv.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Csv.Api.Controllers
{

    [ApiController]
    [Route("temperatures")]
    public class TemperatureController : ControllerBase
    {

        private readonly ITemperatureService _service;


        public TemperatureController(ITemperatureService service)
        {
            _service = service ?? throw new
                        ArgumentNullException(nameof(service));
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            var result = _service.FindAll();
            return Ok(result);
        }

    }
}
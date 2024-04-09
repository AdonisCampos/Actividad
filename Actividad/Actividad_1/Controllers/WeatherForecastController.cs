using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Actividad_1.Controllers
{
    [ApiController]
    [EnableCors("CorsActividad")]
    [Route("[controller]")]
    public class ACTIVIDADController : ControllerBase
    {

        // Endpoint GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("¡Hola desde Web API!");
        }

        // Endpoint POST
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok($"¡Hola, {value}!");
        }
    }
}

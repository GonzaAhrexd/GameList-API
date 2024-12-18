using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet("getPing")]
        public IActionResult Ping()
        {
            return Ok("Pong");
        }
      
    [HttpPost("postContent")]
    public IActionResult PostContent([FromBody] object bodyContent)
    {
        if(bodyContent == null)
        {
            return BadRequest("Invalid request body");
        }


        // Aquí puedes manipular el contenido del cuerpo según sea necesario
        return Ok(bodyContent);
    }

    }




}



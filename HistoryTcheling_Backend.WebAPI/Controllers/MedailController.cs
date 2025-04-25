using Microsoft.AspNetCore.Mvc;

namespace HistoryTcheling_Backend.WebAPI.Controllers
{
    public class MedailController : ControllerBase
    {
        [HttpGet("UserMedailsFromCity")]
        public IActionResult GetMedailsFromUser([FromQuery] string idUser, [FromQuery] string city, [FromQuery] bool onlyClaimedMedail = false)
        {
            return Ok();
        }

        [HttpPost("AddMedailToUser")]
        public IActionResult AddMedailToUser([FromBody] string idUser, [FromBody] string idTouristAttraction)
        {
            return Ok();
        }
    }
}

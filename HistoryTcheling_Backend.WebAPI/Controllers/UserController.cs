using Microsoft.AspNetCore.Mvc;

namespace HistoryTcheling_Backend.WebAPI.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("ValidateUser")]
        public IActionResult ValidateUser([FromQuery] string userEmail, [FromQuery] string passHash)
        {
            return Ok();
        }
    }
}

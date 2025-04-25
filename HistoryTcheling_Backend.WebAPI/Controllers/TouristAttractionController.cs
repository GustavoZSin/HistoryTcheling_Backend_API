using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HistoryTcheling_Backend.WebAPI.Controllers
{
    public class TouristAttractionController : ControllerBase
    {
        [HttpGet("TouristAttractionDetail")]
        public IActionResult Get([FromQuery]string idTouristAttraction)
        {
            return Ok();
        }
    }
}

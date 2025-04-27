using HistoryTcheling_Backend.Domain.Interfaces.UseCases;
using HistoryTcheling_Backend.WebAPI.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace HistoryTcheling_Backend.WebAPI.Controllers
{
    public class MedailController : ControllerBase
    {
        private readonly IGetUserMedailsFromCityUseCase _getUserMedailsUseCase;
        private readonly IAddMedailToUserUseCase _addMedailUseCase;

        public MedailController(IGetUserMedailsFromCityUseCase getUserMedailsUseCase, IAddMedailToUserUseCase addMedailUseCase)
        {
            _getUserMedailsUseCase = getUserMedailsUseCase;
            _addMedailUseCase = addMedailUseCase;
        }

        [HttpGet("UserMedailsFromCity")]
        public async Task<IActionResult> GetMedailsFromUser([FromQuery] GetUserMedailsFromCityRequest request)
        {
            var medails = await _getUserMedailsUseCase.ExecuteAsync(request.IdUser, request.CityName, request.OnlyClaimedMedail);

            if (medails == null)
                return NotFound();

            return Ok(medails);
        }

        [HttpPost("AddMedailToUser")]
        public async Task<IActionResult> AddMedailToUser([FromBody] AddMedailRequest request)
        {
            await _addMedailUseCase.ExecuteAsync(request.IdUser, request.IdTouristAttraction);
            return Created();
        }
    }
}

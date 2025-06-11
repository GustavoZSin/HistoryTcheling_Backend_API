using HistoryTcheling_Backend.Domain.Interfaces.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace HistoryTcheling_Backend.WebAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly ICreateUserUseCase _createUserUseCase;
        private readonly IValidateUserUseCase _validateUserUseCase;

        public UserController(ICreateUserUseCase createUserUseCase, IValidateUserUseCase validateUserUseCase)
        {
            _createUserUseCase = createUserUseCase;
            _validateUserUseCase = validateUserUseCase;
        }
        [HttpGet("ValidateUser")]
        public IActionResult ValidateUser([FromQuery] string userEmail, [FromQuery] string passHash)
        {
            (bool, int) result = _validateUserUseCase.ValidateUser(userEmail, passHash);
            return Ok(new { Valid = result.Item1, Id = result.Item2 });
        }

        [HttpGet("CreateUser")]
        public IActionResult CreateUser([FromQuery] string userName, [FromQuery] string userEmail, [FromQuery] string passHash)
        {
            var result = _createUserUseCase.CreateUser(userName, userEmail, passHash);
            return Ok(new { Id = result.Result });
        }
    }
}
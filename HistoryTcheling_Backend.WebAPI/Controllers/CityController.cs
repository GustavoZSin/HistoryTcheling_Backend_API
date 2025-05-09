using HistoryTcheling_Backend.Domain.Interfaces.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace HistoryTcheling_Backend.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CityController : ControllerBase
{
    private readonly IGetCitiesUseCase _getCitiesUseCase;

    public CityController(IGetCitiesUseCase getCitiesUseCase)
    {
        _getCitiesUseCase = getCitiesUseCase;
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> GetAllCities()
    {
        try
        {
            var cities = await _getCitiesUseCase.GetAllCitiesAsync();

            if (cities == null)
                return NotFound();

            return Ok(cities);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
        }
    }
}

using HistoryTcheling_Backend.Domain.Interfaces.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace HistoryTcheling_Backend.WebAPI.Controllers
{
    public class TouristAttractionController : ControllerBase
    {
        private readonly IGetTouristAttractionDetailUseCase _getTouristAttractionDetail;

        public TouristAttractionController(IGetTouristAttractionDetailUseCase getTouristAttractionDetail)
        {
            _getTouristAttractionDetail = getTouristAttractionDetail;
        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(int id)
        {
            var result = await _getTouristAttractionDetail.ExecuteAsync(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}

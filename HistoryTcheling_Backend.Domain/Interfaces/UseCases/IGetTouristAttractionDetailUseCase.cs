using HistoryTcheling_Backend.Domain.Entities;

namespace HistoryTcheling_Backend.Domain.Interfaces.UseCases
{
    public interface IGetTouristAttractionDetailUseCase
    {
        Task<TouristAttraction> ExecuteAsync(int id);
    }
}

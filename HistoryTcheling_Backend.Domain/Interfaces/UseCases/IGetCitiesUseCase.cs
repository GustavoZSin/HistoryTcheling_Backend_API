using HistoryTcheling_Backend.Domain.Entities;

namespace HistoryTcheling_Backend.Domain.Interfaces.UseCases
{
    public interface IGetCitiesUseCase
    {
        Task<List<City>> GetAllCitiesAsync();
    }
}

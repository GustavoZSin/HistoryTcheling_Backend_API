using HistoryTcheling_Backend.Domain.Entities;

namespace HistoryTcheling_Backend.Domain.Interfaces.Repositories
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllCitiesAsync();
    }
}

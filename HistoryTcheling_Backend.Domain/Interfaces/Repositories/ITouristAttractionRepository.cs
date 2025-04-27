using HistoryTcheling_Backend.Domain.Entities;

namespace HistoryTcheling_Backend.Domain.Interfaces.Repositories
{
    public interface ITouristAttractionRepository
    {
        public Task<TouristAttraction> GetTouristAttractionDetailAsync(int id);
    }
}

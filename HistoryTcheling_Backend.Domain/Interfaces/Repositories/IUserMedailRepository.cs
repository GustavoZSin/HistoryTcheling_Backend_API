using HistoryTcheling_Backend.Domain.Entities;

namespace HistoryTcheling_Backend.Domain.Interfaces.Repositories
{
    public interface IUserMedailRepository
    {
        Task<List<MedalBadgeDetails>> GetUserMedailsFromCityAsync(int userId, string cityName, bool onlyClaimedMedail);
        Task AddMedailToUserAsync(int userId, int touristAttractionId);
    }
}

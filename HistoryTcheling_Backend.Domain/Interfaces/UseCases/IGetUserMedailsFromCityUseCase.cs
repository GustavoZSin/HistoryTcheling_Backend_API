using HistoryTcheling_Backend.Domain.Entities;

namespace HistoryTcheling_Backend.Domain.Interfaces.UseCases
{
    public interface IGetUserMedailsFromCityUseCase
    {
        Task<List<MedalBadgeDetails>> ExecuteAsync(int userId, string cityName, bool onlyClaimedMedail);
    }
}

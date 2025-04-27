using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Domain.Interfaces.UseCases;

namespace HistoryTcheling_Backend.Application.UseCases
{
    public class GetUserMedailsFromCityUseCase : IGetUserMedailsFromCityUseCase
    {
        private readonly IUserMedailRepository _repository;

        public GetUserMedailsFromCityUseCase(IUserMedailRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MedalBadgeDetails>> ExecuteAsync(int userId, string cityName, bool onlyClaimedMedail)
        {
            return await _repository.GetUserMedailsFromCityAsync(userId, cityName, onlyClaimedMedail);
        }
    }
}

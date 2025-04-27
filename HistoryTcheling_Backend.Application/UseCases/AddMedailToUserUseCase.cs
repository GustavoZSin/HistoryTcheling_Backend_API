using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Domain.Interfaces.UseCases;

namespace HistoryTcheling_Backend.Application.UseCases
{
    public class AddMedailToUserUseCase : IAddMedailToUserUseCase
    {
        private readonly IUserMedailRepository _repository;

        public AddMedailToUserUseCase(IUserMedailRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(int userId, int touristAttractionId)
        {
            await _repository.AddMedailToUserAsync(userId, touristAttractionId);
        }
    }
}

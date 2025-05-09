using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Domain.Interfaces.UseCases;

namespace HistoryTcheling_Backend.Application.UseCases
{
    public class GetCitiesUseCase : IGetCitiesUseCase
    {
        private readonly ICityRepository _repository;

        public GetCitiesUseCase(ICityRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<City>> GetAllCitiesAsync()
        {
            return await _repository.GetAllCitiesAsync();
        }
    }
}

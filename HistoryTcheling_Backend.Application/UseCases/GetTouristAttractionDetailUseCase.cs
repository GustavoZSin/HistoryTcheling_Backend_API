using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Domain.Interfaces.UseCases;

namespace HistoryTcheling_Backend.Application.UseCases
{
    public class GetTouristAttractionDetailUseCase : IGetTouristAttractionDetailUseCase
    {
        private readonly ITouristAttractionRepository _repository;

        public GetTouristAttractionDetailUseCase(ITouristAttractionRepository repository)
        {
            _repository = repository;
        }

        public async Task<TouristAttraction> ExecuteAsync(int id)
        {
            return await _repository.GetTouristAttractionDetailAsync(id);
        }
    }
}

using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;

namespace HistoryTcheling_Backend.Infraestructure.Mappers
{
    public class CityMapper : IMapper<CityModel, City>
    {
        private readonly IMapper<StateModel, State> _mapper;

        public CityMapper(IMapper<StateModel, State> mapper)
        {
            _mapper = mapper;
        }
        public City MapToDestination(CityModel source)
        {
            return new City
            {
                Id = source.Id,
                Name = source.Name,
                State = source.IdStateNavigation == null ? null : _mapper.MapToDestination(source.IdStateNavigation)
            };
        }

        public CityModel MapToSource(City destination)
        {
            return new CityModel
            {
                Name = destination.Name,
                IdState = destination.State.Id,
            };
        }
    }
}

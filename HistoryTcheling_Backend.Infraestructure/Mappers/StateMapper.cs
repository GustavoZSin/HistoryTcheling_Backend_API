using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryTcheling_Backend.Infraestructure.Mappers
{
    public class StateMapper : IMapper<StateModel, State>
    {
        private readonly IMapper<CountryModel, Country> _mapper;

        public StateMapper(IMapper<CountryModel, Country> mapper)
        {
            _mapper = mapper;
        }

        public State MapToDestination(StateModel source)
        {
            return new State
            {
                Name = source.Name,
                Acronym = source.Acronym,
                Id = source.Id,
                Country = source.IdCountryNavigation == null ? null : _mapper.MapToDestination(source.IdCountryNavigation)
            };
        }

        public StateModel MapToSource(State destination)
        {
            return new StateModel
            {
                Name = destination.Name,
                Acronym = destination.Acronym,
                IdCountry = destination.Country.Id,
            };
        }
    }
}

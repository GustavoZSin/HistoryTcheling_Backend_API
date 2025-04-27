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
    public class CountryMapper : IMapper<CountryModel, Country>
    {
        public Country MapToDestination(CountryModel source)
        {
            return new Country
            {
                Id = source.Id,
                Name = source.Name,
                Acronym = source.Acronym
            };
        }

        public CountryModel MapToSource(Country destination)
        {
            return new CountryModel
            {
                Name = destination.Name,
                Acronym = destination.Acronym
            };
        }
    }
}

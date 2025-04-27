using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;

namespace HistoryTcheling_Backend.Infraestructure.Mappers
{
    public class AddressMapper : IMapper<AddressModel, Address>
    {
        private readonly IMapper<CityModel, City> _mapper;
        public AddressMapper(IMapper<CityModel, City> cityMapper)
        {
            _mapper = cityMapper;
        }

        public Address MapToDestination(AddressModel model)
        {
            return new Address
            {
                Id = model.Id,
                Street = model.Street,
                Neighborhood = model.Neighborhood,
                City = model.IdCityNavigation == null ? null : _mapper.MapToDestination(model.IdCityNavigation),
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Number = model.Number,
            };
        }

        public AddressModel MapToSource(Address destination)
        {
            return new AddressModel
            {
                Street = destination.Street,
                Neighborhood = destination.Neighborhood,
                Number = destination.Number,
                Latitude = destination.Latitude,
                Longitude = destination.Longitude,
            };
        }
    }
}

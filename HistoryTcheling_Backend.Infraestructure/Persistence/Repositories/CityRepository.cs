using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Infraestructure.Persistence.Context;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly HistoryTchelingContext _context;
        private readonly IMapper<CityModel, City> _mapper;

        public CityRepository(HistoryTchelingContext context, IMapper<CityModel, City> mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<City>> GetAllCitiesAsync()
        {
            var query = _context.Cities
                .Include(c => c.IdStateNavigation)
                    .ThenInclude(s => s.IdCountryNavigation);

            var cities = await query.ToListAsync();

            if (cities == null)
                return null;

            List<City> cityList = new();

            foreach (var cityModel in cities)
            {
                var city = _mapper.MapToDestination(cityModel);
                cityList.Add(city);
            }

            return cityList;
        }
    }
}

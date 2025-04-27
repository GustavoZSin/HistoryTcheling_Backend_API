using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Infraestructure.Mappers;
using HistoryTcheling_Backend.Infraestructure.Persistence.Context;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Repositories
{
    public class TouristAttractionRepository : ITouristAttractionRepository
    {
        private readonly HistoryTchelingContext _context;
        private readonly IMapper<TouristAttractionModel, TouristAttraction> _mapper;

        public TouristAttractionRepository(HistoryTchelingContext context, IMapper<TouristAttractionModel, TouristAttraction> mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TouristAttraction> GetTouristAttractionDetailAsync(int id)
        {
            var touristAttractionModel = await _context.TouristAttractions
                .Include(t => t.Category)
                .Include(t => t.BackgroundImage)
                .Include(t => t.Icon)
                .Include(t => t.Address)
                    .ThenInclude(a => a.IdCityNavigation)
                        .ThenInclude(c => c.IdStateNavigation)
                            .ThenInclude(s => s.IdCountryNavigation)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (touristAttractionModel == null)
                return null;

            TouristAttraction touristAttraction = _mapper.MapToDestination(touristAttractionModel);

            return touristAttraction;
        }
    }
}

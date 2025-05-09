using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Infraestructure.Persistence.Context;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Repositories
{
    public class UserMedailRepository : IUserMedailRepository
    {
        private readonly HistoryTchelingContext _context;
        private readonly IMapper<UserVisitedAttractionModel, MedalBadgeDetails> _mapper;

        public UserMedailRepository(HistoryTchelingContext context, IMapper<UserVisitedAttractionModel, MedalBadgeDetails> mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<MedalBadgeDetails>> GetUserMedailsFromCityAsync(int userId, string cityName, bool onlyClaimedMedail)
        {
            var query = _context.UserVisitedAttractions
                    .Include(uva => uva.IdTouristAttractionNavigation)
                        .ThenInclude(ta => ta.Icon)
                    .Include(uva => uva.IdTouristAttractionNavigation)
                        .ThenInclude(ta => ta.Address)
                            .ThenInclude(ad => ad.IdCityNavigation)
                                .ThenInclude(c => c.IdStateNavigation)
                                    .ThenInclude(s => s.IdCountryNavigation);

            var detailList = await query
                    .Where(a => a.IdUser == userId
                             && a.IdTouristAttractionNavigation.Address.IdCityNavigation.Name == cityName)
                    .ToListAsync();

            List<MedalBadgeDetails> results = new();

            foreach (var detail in detailList)
            {
                var mappedResult = _mapper.MapToDestination(detail);
                results.Add(mappedResult);
            }

            return results;
        }

        public async Task AddMedailToUserAsync(int userId, int touristAttractionId)
        {
            var newMedail = new UserVisitedAttractionModel
            {
                IdUser = userId,
                IdTouristAttraction = touristAttractionId
            };

            await _context.UserVisitedAttractions.AddAsync(newMedail);
            await _context.SaveChangesAsync();
        }
    }
}

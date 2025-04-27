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
    public class UserVisitedAttractionMapper : IMapper<UserVisitedAttractionModel, MedalBadgeDetails>
    {
        private readonly IMapper<ImageModel, Image> _imageMapper;

        public UserVisitedAttractionMapper(IMapper<ImageModel, Image> imageMapper)
        {
            _imageMapper = imageMapper;
        }
        public MedalBadgeDetails MapToDestination(UserVisitedAttractionModel model)
        {
            var address = model.IdTouristAttractionNavigation.Address;
            string formatedLocalization = $"{address.Neighborhood},{address.IdCityNavigation.Name} - {address.IdCityNavigation.IdStateNavigation.Name}";

            string formatedUrl = $"https://www.google.com/maps/search/{model.IdTouristAttractionNavigation.Name.Replace(" ", "+")}+-+{address.Neighborhood.Replace(" ", "+")},+{address.IdCityNavigation.Name.Replace(" ", "+")}";

            return new MedalBadgeDetails
            {
                Title = model.IdTouristAttractionNavigation.Name,
                //Converter FilePath para IconBase64 depois
                IconData = _imageMapper.MapToDestination(model.IdTouristAttractionNavigation.Icon),
                Localization = formatedLocalization,
                MapsUrl = formatedUrl,
                Claimed = true,
                ClaimedDate = Convert.ToDateTime(model.VisitedDate)
            };
        }

        public UserVisitedAttractionModel MapToSource(MedalBadgeDetails domain)
        {
            return new UserVisitedAttractionModel { };
        }
    }
}

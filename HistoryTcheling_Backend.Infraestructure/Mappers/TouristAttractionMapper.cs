using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;

namespace HistoryTcheling_Backend.Infraestructure.Mappers
{
    public class TouristAttractionMapper : IMapper<TouristAttractionModel, TouristAttraction>
    {
        private readonly IMapper<AddressModel, Address> _addressMapper;
        private readonly IMapper<ImageModel, Image> _imageMapper;
        private readonly IMapper<CategoryModel, Category> _categoryMapper;
        public TouristAttractionMapper(IMapper<AddressModel, Address> addressMapper, IMapper<ImageModel, Image> imageMapper, IMapper<CategoryModel, Category> categoryMapper)
        {
            _addressMapper = addressMapper;
            _imageMapper = imageMapper;
            _categoryMapper = categoryMapper;
        }
        public TouristAttraction MapToDestination(TouristAttractionModel model)
        {
            var touristAttraction = new TouristAttraction() {
                Id = model.Id,
                Name = model.Name,
                ConstructionYear = model.ConstructionYear,
                Description = model.Description,
            };

            touristAttraction.Address = model.Address == null ? null : _addressMapper.MapToDestination(model.Address);
            touristAttraction.BackgroundImage = model.BackgroundImage == null ? null : _imageMapper.MapToDestination(model.BackgroundImage);
            touristAttraction.Category = model.Category == null ? null : _categoryMapper.MapToDestination(model.Category);
            touristAttraction.Icon = model.Icon == null ? null : _imageMapper.MapToDestination(model.Icon);

            return touristAttraction;
        }
        public TouristAttractionModel MapToSource(TouristAttraction domain)
        {
            return new TouristAttractionModel
            {
                Name = domain.Name,
                ConstructionYear = domain.ConstructionYear,
                Description = domain.Description,
                BackgroundImageId = domain.BackgroundImage?.Id,
                IconId = domain.Icon?.Id,
                AddressId = domain.Address?.Id,
                CategoryId = domain.Category?.Id 
            };
        }
    }
}

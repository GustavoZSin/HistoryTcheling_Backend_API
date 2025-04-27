using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;

namespace HistoryTcheling_Backend.Infraestructure.Mappers
{
    public class CategoryMapper : IMapper<CategoryModel, Category>
    {
        public Category MapToDestination(CategoryModel model)
        {
            return new Category
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public CategoryModel MapToSource(Category destination)
        {
            return new CategoryModel
            {
                Name = destination.Name
            };
        }
    }
}

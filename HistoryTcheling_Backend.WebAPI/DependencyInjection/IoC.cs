using HistoryTcheling_Backend.Application.UseCases;
using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Domain.Interfaces.UseCases;
using HistoryTcheling_Backend.Infraestructure.Mappers;
using HistoryTcheling_Backend.Infraestructure.Persistence.Context;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;
using HistoryTcheling_Backend.Infraestructure.Persistence.Repositories;

namespace HistoryTcheling_Backend.WebAPI.DependencyInjection
{
    public static class IoC
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            //DbContext
            services.AddDbContext<HistoryTchelingContext>();

            //Mappers
            services.AddScoped<IMapper<TouristAttractionModel, TouristAttraction>, TouristAttractionMapper>();
            services.AddScoped<IMapper<AddressModel, Address>, AddressMapper>();
            services.AddScoped<IMapper<CityModel, City>, CityMapper>();
            services.AddScoped<IMapper<StateModel, State>, StateMapper>();
            services.AddScoped<IMapper<CategoryModel, Category>, CategoryMapper>();
            services.AddScoped<IMapper<CountryModel, Country>, CountryMapper>();
            services.AddScoped<IMapper<ImageModel, Image>, ImageMapper>();
            services.AddScoped<IMapper<UserVisitedAttractionModel, MedalBadgeDetails>, UserVisitedAttractionMapper>();

            //Repositories
            services.AddScoped<ITouristAttractionRepository, TouristAttractionRepository>();
            services.AddScoped<IUserMedailRepository, UserMedailRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Add application services here
            services.AddScoped<IGetTouristAttractionDetailUseCase, GetTouristAttractionDetailUseCase>();
            services.AddScoped<IAddMedailToUserUseCase, AddMedailToUserUseCase>();
            services.AddScoped<IGetUserMedailsFromCityUseCase, GetUserMedailsFromCityUseCase>();
            services.AddScoped<IGetCitiesUseCase, GetCitiesUseCase>();
            services.AddScoped<ICreateUserUseCase, CreateUserUseCase>();
            services.AddScoped<IValidateUserUseCase, ValidateUserUseCase>();

            return services;
        }
    }
}

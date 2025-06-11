using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Domain.Interfaces.UseCases;

namespace HistoryTcheling_Backend.Application.UseCases
{
    public class CreateUserUseCase : ICreateUserUseCase
    {
        private readonly IUserRepository _repository;

        public CreateUserUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateUser(string userName, string userEmail, string userHashPass)
        {
            return _repository.CreateUser(userName, userEmail, userHashPass);
        }
    }
}

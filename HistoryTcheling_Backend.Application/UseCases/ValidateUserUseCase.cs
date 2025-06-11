using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Domain.Interfaces.UseCases;

namespace HistoryTcheling_Backend.Application.UseCases
{
    public class ValidateUserUseCase : IValidateUserUseCase
    {
        private readonly IUserRepository _repository;

        public ValidateUserUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public (bool, int) ValidateUser(string userEmail, string passHash)
        {
            return _repository.ValidateUser(userEmail, passHash);
        }
    }
}


namespace HistoryTcheling_Backend.Domain.Interfaces.UseCases
{
    public interface ICreateUserUseCase
    {
        Task<int> CreateUser(string userName, string userEmail, string userHashPass);
    }
}

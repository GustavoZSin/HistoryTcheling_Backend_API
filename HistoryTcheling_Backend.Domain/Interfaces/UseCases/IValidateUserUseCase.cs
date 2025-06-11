namespace HistoryTcheling_Backend.Domain.Interfaces.UseCases
{
    public interface IValidateUserUseCase
    {
        (bool, int) ValidateUser(string userEmail, string passHash);
    }
}

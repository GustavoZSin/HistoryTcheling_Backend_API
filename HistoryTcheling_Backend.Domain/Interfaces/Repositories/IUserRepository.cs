namespace HistoryTcheling_Backend.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        int CreateUser(string userName, string userEmail, string userHashPass);
        (bool, int) ValidateUser(string userEmail, string passHash);
    }
}

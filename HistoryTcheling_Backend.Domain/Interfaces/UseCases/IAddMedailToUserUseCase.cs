namespace HistoryTcheling_Backend.Domain.Interfaces.UseCases
{
    public interface IAddMedailToUserUseCase
    {
        Task ExecuteAsync(int userId, int touristAttractionId);
    }
}

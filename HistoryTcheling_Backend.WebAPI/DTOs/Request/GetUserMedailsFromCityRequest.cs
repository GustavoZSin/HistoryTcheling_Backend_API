namespace HistoryTcheling_Backend.WebAPI.DTOs.Request
{
    public class GetUserMedailsFromCityRequest
    {
        public int IdUser { get; set; }
        public string CityName { get; set; }
        public bool OnlyClaimedMedail { get; set; } = false;
    }
}

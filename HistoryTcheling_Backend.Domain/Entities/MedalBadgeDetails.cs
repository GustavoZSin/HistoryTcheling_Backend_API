namespace HistoryTcheling_Backend.Domain.Entities
{
    public class MedalBadgeDetails
    {
        public string Title { get; set; }
        public Image IconData { get; set; }
        public string Localization { get; set; }
        public bool Claimed { get; set; }
        public DateTime ClaimedDate { get; set; }
        public string MapsUrl { get; set; }
    }
}
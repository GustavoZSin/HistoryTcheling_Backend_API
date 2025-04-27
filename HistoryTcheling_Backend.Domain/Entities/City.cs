using System.Text.Json.Serialization;

namespace HistoryTcheling_Backend.Domain.Entities;

public partial class City
{
    [JsonIgnore]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public State State { get; set; }
}

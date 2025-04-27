using System.Text.Json.Serialization;

namespace HistoryTcheling_Backend.Domain.Entities;

public partial class TouristAttraction
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int? ConstructionYear { get; set; }
    public string? Description { get; set; }

    public virtual Address? Address { get; set; }
    public virtual Image? BackgroundImage { get; set; }
    public virtual Category? Category { get; set; }
    public virtual Image? Icon { get; set; }
}

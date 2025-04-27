namespace HistoryTcheling_Backend.Infraestructure.Persistence.Models;

public partial class TouristAttractionModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? ConstructionYear { get; set; }

    public string? Description { get; set; }

    public int? BackgroundImageId { get; set; }

    public int? IconId { get; set; }

    public int? AddressId { get; set; }

    public int? CategoryId { get; set; }

    public virtual AddressModel? Address { get; set; }

    public virtual ImageModel? BackgroundImage { get; set; }

    public virtual CategoryModel? Category { get; set; }

    public virtual ImageModel? Icon { get; set; }

    public virtual ICollection<UserVisitedAttractionModel> UserVisitedAttractions { get; set; } = new List<UserVisitedAttractionModel>();
}

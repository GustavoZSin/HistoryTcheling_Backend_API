namespace HistoryTcheling_Backend.Infraestructure.Persistence.Models;

public partial class AddressModel
{
    public int Id { get; set; }

    public string Neighborhood { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int? Number { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public int IdCity { get; set; }

    public virtual CityModel IdCityNavigation { get; set; } = null!;

    public virtual ICollection<TouristAttractionModel> TouristAttractions { get; set; } = new List<TouristAttractionModel>();

    public virtual ICollection<UserModel> Users { get; set; } = new List<UserModel>();
}

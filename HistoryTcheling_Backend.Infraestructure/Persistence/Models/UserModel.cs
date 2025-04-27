namespace HistoryTcheling_Backend.Infraestructure.Persistence.Models;

public partial class UserModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public string HashPass { get; set; } = null!;

    public int IdAddress { get; set; }

    public virtual AddressModel IdAddressNavigation { get; set; } = null!;

    public virtual ICollection<UserVisitedAttractionModel> UserVisitedAttractions { get; set; } = new List<UserVisitedAttractionModel>();
}
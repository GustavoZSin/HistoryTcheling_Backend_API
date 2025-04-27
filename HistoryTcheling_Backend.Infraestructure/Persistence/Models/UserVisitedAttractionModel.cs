namespace HistoryTcheling_Backend.Infraestructure.Persistence.Models;

public partial class UserVisitedAttractionModel
{
    public int Id { get; set; }

    public DateTime? VisitedDate { get; set; }

    public int? IdUser { get; set; }

    public int? IdTouristAttraction { get; set; }

    public virtual TouristAttractionModel? IdTouristAttractionNavigation { get; set; }

    public virtual UserModel? IdUserNavigation { get; set; }
}

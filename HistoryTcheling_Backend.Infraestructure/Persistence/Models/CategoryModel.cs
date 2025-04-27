using System;
using System.Collections.Generic;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Models;

public partial class CategoryModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TouristAttractionModel> TouristAttractions { get; set; } = new List<TouristAttractionModel>();
}

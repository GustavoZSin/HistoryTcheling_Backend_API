using System;
using System.Collections.Generic;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Models;

public partial class ImageModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string FileExtension { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public virtual ICollection<TouristAttractionModel> TouristAttractionBackgroundImages { get; set; } = new List<TouristAttractionModel>();

    public virtual ICollection<TouristAttractionModel> TouristAttractionIcons { get; set; } = new List<TouristAttractionModel>();
}

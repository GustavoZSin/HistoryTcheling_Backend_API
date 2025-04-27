using System;
using System.Collections.Generic;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Models;

public partial class CountryModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Acronym { get; set; }

    public virtual ICollection<StateModel> States { get; set; } = new List<StateModel>();
}

using System;
using System.Collections.Generic;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Models;

public partial class StateModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Acronym { get; set; }

    public int IdCountry { get; set; }

    public virtual ICollection<CityModel> Cities { get; set; } = new List<CityModel>();

    public virtual CountryModel IdCountryNavigation { get; set; } = null!;
}

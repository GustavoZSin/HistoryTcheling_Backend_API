using System;
using System.Collections.Generic;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Models;

public partial class CityModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdState { get; set; }

    public virtual ICollection<AddressModel> Addresses { get; set; } = new List<AddressModel>();

    public virtual StateModel IdStateNavigation { get; set; } = null!;
}

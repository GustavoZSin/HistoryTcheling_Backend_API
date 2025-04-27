using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HistoryTcheling_Backend.Domain.Entities;

public partial class Address
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Neighborhood { get; set; } = null!;
    public string Street { get; set; } = null!;
    public int? Number { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public City City { get; set; }
}

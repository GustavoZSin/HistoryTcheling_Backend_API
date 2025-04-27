using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HistoryTcheling_Backend.Domain.Entities;

public partial class Country
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Acronym { get; set; }
}

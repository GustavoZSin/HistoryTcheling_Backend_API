using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HistoryTcheling_Backend.Domain.Entities;

public class Image
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string FileExtension { get; set; } = null!; 
    [JsonIgnore]
    public string FilePath { get; set; }
    public string? ImageBase64 { get; set; }
}

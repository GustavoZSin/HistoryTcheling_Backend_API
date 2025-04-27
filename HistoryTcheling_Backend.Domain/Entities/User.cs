using System;
using System.Collections.Generic;

namespace HistoryTcheling_Backend.Domain.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public string HashPass { get; set; } = null!;

    public int IdAddress { get; set; }

    public virtual Address IdAddressNavigation { get; set; } = null!;
}

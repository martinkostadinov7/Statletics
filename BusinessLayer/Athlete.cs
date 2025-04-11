using System;
using System.Collections.Generic;

namespace BusinessLayer;

public partial class Athlete
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string? Club { get; set; }

    public string? Notes { get; set; }

    public virtual List<Run> Runs { get; set; } = new List<Run>();
}

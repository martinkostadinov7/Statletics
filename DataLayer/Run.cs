using System;
using System.Collections.Generic;

namespace DataLayer;

public partial class Run
{
    public int Id { get; set; }

    public int AthleteId { get; set; }

    public DateTime Date { get; set; }

    public int Distance { get; set; }

    public double TimeSeconds { get; set; }

    public bool IsHandTimed { get; set; }

    public int? Repetition { get; set; }

    public int? TotalRepetitions { get; set; }

    public TimeSpan? RestBetween { get; set; }

    public string? Shoes { get; set; }

    public string? Notes { get; set; }

    public virtual Athlete Athlete { get; set; } = null!;
}

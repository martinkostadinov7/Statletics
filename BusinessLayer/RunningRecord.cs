using System;
using System.Collections.Generic;

namespace BusinessLayer;

public partial class RunningRecord
{
    public int Id { get; set; }

    public int IdDiscipline { get; set; }

    public DateTime DateTime { get; set; }

    public TimeSpan Result { get; set; }

    public bool? HasSpikes { get; set; }

    public string? ActivityType { get; set; }

    public bool? IsOutdoor { get; set; }
    private RunningRecord()
    {
        
    }

    public RunningRecord(int idDiscipline, TimeSpan result, bool? hasSpikes, string? activityType, bool? isOutdoor)
    {
        IdDiscipline = idDiscipline;
        Result = result;
        HasSpikes = hasSpikes;
        ActivityType = activityType;
        IsOutdoor = isOutdoor;
    }
}

namespace PalTracker{
    public static class MappingExtensions{
        public static TimeEntry ToEntity(this TimeEntryRecord record)=>new TimeEntry{
            Date=record.Date,
            Hours= record.Hours,
            Id= record.Id,
            ProjectId= record.ProjectId,
            UserId =record.UserId
        };
        public static TimeEntryRecord ToRecord(this TimeEntry record)=>new TimeEntryRecord{
            Date=record.Date,
            Hours= record.Hours,
            Id= record.Id,
            ProjectId= record.ProjectId,
            UserId =record.UserId
        };

    }
}
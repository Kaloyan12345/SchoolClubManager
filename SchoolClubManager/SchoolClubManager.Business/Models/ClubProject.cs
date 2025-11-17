namespace SchoolClubManager.Business.Models;

public enum ProjectStatus
{
    Draft,
    Researching,
    BuildingPrototype,
    Testing,
    ReadyForExpo
}

public class ClubProject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Theme { get; set; } = string.Empty;
    public ClubTeam Team { get; set; } = new();
    public Mentor Mentor { get; set; } = new();
    public Student StudentLead { get; set; } = new();
    public DayOfWeek MeetingDay { get; set; } = DayOfWeek.Friday;
    public ProjectStatus Status { get; set; } = ProjectStatus.Draft;
    public List<TaskItem> Tasks { get; set; } = new();
    public string Notes { get; set; } = string.Empty;
}


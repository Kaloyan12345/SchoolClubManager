namespace SchoolClubManager.Business.Models;

public class TaskItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Description { get; set; } = string.Empty;
    public int EstimatedHours { get; set; }
    public bool IsCompleted { get; set; }
}


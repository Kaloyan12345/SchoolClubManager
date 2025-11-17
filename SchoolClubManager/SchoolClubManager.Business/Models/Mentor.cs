namespace SchoolClubManager.Business.Models;

public class Mentor
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } = string.Empty;
    public string Role { get; set; } = "Учител";
    public string Email { get; set; } = string.Empty;
}


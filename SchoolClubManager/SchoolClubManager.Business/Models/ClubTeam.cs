namespace SchoolClubManager.Business.Models;

public class ClubTeam
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Motto { get; set; } = string.Empty;
    public List<Student> Members { get; set; } = new();

    public override string ToString() => Name;
}


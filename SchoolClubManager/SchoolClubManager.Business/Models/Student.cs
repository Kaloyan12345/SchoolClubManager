namespace SchoolClubManager.Business.Models;

public class Student
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Grade { get; set; } = 0;
    public string FavoriteSubject { get; set; } = string.Empty;
    public override string ToString()
    {
        var name = $"{FirstName} {LastName}".Trim();

        if (Grade > 0)
        {
            return $"{name} ({Grade} кл.)";
        }

        return name;
    }
}


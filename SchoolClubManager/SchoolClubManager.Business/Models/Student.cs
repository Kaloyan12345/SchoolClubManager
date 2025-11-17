namespace SchoolClubManager.Business.Models;

public class Student
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Grade { get; set; }
    public string FavoriteSubject { get; set; } = string.Empty;

    public override string ToString() => $"{FirstName} {LastName} ({Grade} кл.)";
}


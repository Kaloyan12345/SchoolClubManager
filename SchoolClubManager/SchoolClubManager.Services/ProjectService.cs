using System.IO;
using SchoolClubManager.Business.Models;
using SchoolClubManager.Data.Repositories;
using SchoolClubManager.Services.Contracts;

namespace SchoolClubManager.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _repository;

    public static ProjectService CreateInMemory()
        => new(new InMemoryProjectRepository());

    public static ProjectService CreateSqlite(string? databasePath = null)
    {
        databasePath ??= Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "SchoolClubManager",
            "clubProjects.db");

        return new ProjectService(new SqliteProjectRepository(databasePath));
    }

    public ProjectService(IProjectRepository repository)
    {
        _repository = repository;
    }

    public IReadOnlyList<ClubProject> GetAll() => _repository.GetAll();

    public ClubProject Create(ClubProject project)
    {
        if (project.Id == Guid.Empty)
        {
            project.Id = Guid.NewGuid();
        }

        Normalize(project);
        _repository.Add(project);
        return project;
    }

    public void Update(ClubProject project)
    {
        Normalize(project);
        _repository.Update(project);
    }

    public void Delete(Guid id) => _repository.Delete(id);

    private static void Normalize(ClubProject project)
    {
        project.Title = project.Title.Trim();
        project.Theme = project.Theme.Trim();
        project.Mentor ??= new Mentor();
        project.Team ??= new ClubTeam();
        project.StudentLead ??= new Student();
        project.Tasks ??= new List<TaskItem>();
        project.Team.Members ??= new List<Student>();
    }
}


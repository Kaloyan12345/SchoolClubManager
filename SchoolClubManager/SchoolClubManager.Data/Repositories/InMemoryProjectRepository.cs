using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public class InMemoryProjectRepository : IProjectRepository
{
    private readonly List<ClubProject> _projects = new();

    public List<ClubProject> GetAll() => _projects
        .OrderBy(p => p.Title, StringComparer.CurrentCultureIgnoreCase)
        .ToList();

    public ClubProject? GetById(Guid id) => _projects.FirstOrDefault(p => p.Id == id);

    public void Add(ClubProject project)
    {
        if (_projects.Any(p => p.Id == project.Id))
        {
            project.Id = Guid.NewGuid();
        }

        _projects.Add(project);
    }

    public void Update(ClubProject project)
    {
        var index = _projects.FindIndex(p => p.Id == project.Id);
        if (index == -1)
        {
            return;
        }

        _projects[index] = project;
    }

    public void Delete(Guid id)
    {
        var existing = _projects.FirstOrDefault(p => p.Id == id);
        if (existing is not null)
        {
            _projects.Remove(existing);
        }
    }
}


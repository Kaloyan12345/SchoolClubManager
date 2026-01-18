using SchoolClubManager.Business.Models;
using SchoolClubManager.Data.Repositories;
using SchoolClubManager.Services.Contracts;

namespace SchoolClubManager.Services;

public class ClubTeamService : IClubTeamService
{
    private readonly IClubTeamRepository _repository;

    public ClubTeamService(IClubTeamRepository repository) => _repository = repository;

    public IReadOnlyList<ClubTeam> GetAll() => _repository.GetAll();
    public ClubTeam? GetById(Guid id) => _repository.GetById(id);

    public ClubTeam Create(ClubTeam team)
    {
        if (team.Id == Guid.Empty) team.Id = Guid.NewGuid();
        Normalize(team);
        _repository.Add(team);
        return team;
    }

    public void Update(ClubTeam team)
    {
        Normalize(team);
        _repository.Update(team);
    }

    public void Delete(Guid id) => _repository.Delete(id);

    private static void Normalize(ClubTeam t)
    {
        t.Name = (t.Name ?? string.Empty).Trim();
        t.Motto = (t.Motto ?? string.Empty).Trim();
        t.Members ??= new List<Student>();
    }
}

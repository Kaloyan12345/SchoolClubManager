using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public class InMemoryClubTeamRepository : IClubTeamRepository
{
    private readonly List<ClubTeam> _teams = new();

    public List<ClubTeam> GetAll() => _teams
        .OrderBy(t => t.Name, StringComparer.CurrentCultureIgnoreCase)
        .ToList();

    public ClubTeam? GetById(Guid id) => _teams.FirstOrDefault(t => t.Id == id);

    public void Add(ClubTeam team)
    {
        if (_teams.Any(t => t.Id == team.Id))
        {
            team.Id = Guid.NewGuid();
        }

        _teams.Add(team);
    }

    public void Update(ClubTeam team)
    {
        var index = _teams.FindIndex(t => t.Id == team.Id);
        if (index == -1)
        {
            return;
        }

        _teams[index] = team;
    }

    public void Delete(Guid id)
    {
        var existing = _teams.FirstOrDefault(t => t.Id == id);
        if (existing is not null)
        {
            _teams.Remove(existing);
        }
    }
}

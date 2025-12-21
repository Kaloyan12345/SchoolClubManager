using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public class InMemoryMentorRepository : IMentorRepository
{
    private readonly List<Mentor> _mentors = new();

    public List<Mentor> GetAll() => _mentors
        .OrderBy(m => m.FullName, StringComparer.CurrentCultureIgnoreCase)
        .ToList();

    public Mentor? GetById(Guid id) => _mentors.FirstOrDefault(m => m.Id == id);

    public void Add(Mentor mentor)
    {
        if (_mentors.Any(m => m.Id == mentor.Id))
        {
            mentor.Id = Guid.NewGuid();
        }

        _mentors.Add(mentor);
    }

    public void Update(Mentor mentor)
    {
        var index = _mentors.FindIndex(m => m.Id == mentor.Id);
        if (index == -1)
        {
            return;
        }

        _mentors[index] = mentor;
    }

    public void Delete(Guid id)
    {
        var existing = _mentors.FirstOrDefault(m => m.Id == id);
        if (existing is not null)
        {
            _mentors.Remove(existing);
        }
    }
}

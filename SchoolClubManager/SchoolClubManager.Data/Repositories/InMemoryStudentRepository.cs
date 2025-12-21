using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public class InMemoryStudentRepository : IStudentRepository
{
    private readonly List<Student> _students = new();

    public List<Student> GetAll() => _students
        .OrderBy(s => s.LastName, StringComparer.CurrentCultureIgnoreCase)
        .ThenBy(s => s.FirstName, StringComparer.CurrentCultureIgnoreCase)
        .ToList();

    public Student? GetById(Guid id) => _students.FirstOrDefault(s => s.Id == id);

    public void Add(Student student)
    {
        if (_students.Any(s => s.Id == student.Id))
        {
            student.Id = Guid.NewGuid();
        }

        _students.Add(student);
    }

    public void Update(Student student)
    {
        var index = _students.FindIndex(s => s.Id == student.Id);
        if (index == -1)
        {
            return;
        }

        _students[index] = student;
    }

    public void Delete(Guid id)
    {
        var existing = _students.FirstOrDefault(s => s.Id == id);
        if (existing is not null)
        {
            _students.Remove(existing);
        }
    }
}

using SchoolClubManager.Business.Models;
using SchoolClubManager.Data.Repositories;
using SchoolClubManager.Services.Contracts;

namespace SchoolClubManager.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository) => _repository = repository;

    public IReadOnlyList<Student> GetAll() => _repository.GetAll();
    public Student? GetById(Guid id) => _repository.GetById(id);

    public Student Create(Student student)
    {
        if (student.Id == Guid.Empty) student.Id = Guid.NewGuid();
        Normalize(student);
        _repository.Add(student);
        return student;
    }

    public void Update(Student student)
    {
        Normalize(student);
        _repository.Update(student);
    }

    public void Delete(Guid id) => _repository.Delete(id);

    private static void Normalize(Student s)
    {
        s.FirstName = (s.FirstName ?? string.Empty).Trim();
        s.LastName = (s.LastName ?? string.Empty).Trim();
        s.FavoriteSubject = (s.FavoriteSubject ?? string.Empty).Trim();
        if (s.Grade < 1) s.Grade = 1;
    }
}

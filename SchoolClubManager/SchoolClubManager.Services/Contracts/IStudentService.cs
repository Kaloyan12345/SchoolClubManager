using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Services.Contracts;

public interface IStudentService
{
    IReadOnlyList<Student> GetAll();
    Student? GetById(Guid id);
    Student Create(Student student);
    void Update(Student student);
    void Delete(Guid id);
}

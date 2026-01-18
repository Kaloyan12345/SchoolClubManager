using SchoolClubManager.Business.Models;
using SchoolClubManager.Data.Repositories;
using SchoolClubManager.Services;
using Xunit;

namespace SchoolClubManager.Tests;

public class StudentServiceCrudTests
{
    private readonly StudentService _service;

    public StudentServiceCrudTests()
    {
        _service = new StudentService(new InMemoryStudentRepository());
    }

    [Fact]
    public void Create_AddsStudent()
    {
        var student = new Student
        {
            FirstName = "Ani",
            LastName = "Ivanova",
            Grade = 10,
            FavoriteSubject = "Math"
        };

        _service.Create(student);

        Assert.Single(_service.GetAll());
    }

    [Fact]
    public void Read_GetById_ReturnsStudent()
    {
        var student = _service.Create(new Student
        {
            FirstName = "Bobi",
            LastName = "Dimitrov",
            Grade = 9,
            FavoriteSubject = "IT"
        });

        var found = _service.GetById(student.Id);

        Assert.NotNull(found);
        Assert.Equal("Bobi", found!.FirstName);
    }

    [Fact]
    public void Update_ChangesStudent()
    {
        var student = _service.Create(new Student
        {
            FirstName = "Tedi",
            LastName = "Lazarov",
            Grade = 10,
            FavoriteSubject = "Physics"
        });

        student.Grade = 11;
        _service.Update(student);

        var updated = _service.GetById(student.Id);
        Assert.Equal(11, updated!.Grade);
    }

    [Fact]
    public void Delete_RemovesStudent()
    {
        var student = _service.Create(new Student
        {
            FirstName = "Kris",
            LastName = "Petrov",
            Grade = 8,
            FavoriteSubject = "Biology"
        });

        _service.Delete(student.Id);

        Assert.Empty(_service.GetAll());
        Assert.Null(_service.GetById(student.Id));
    }
}

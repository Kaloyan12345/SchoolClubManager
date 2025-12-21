using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public interface IStudentRepository
{
    List<Student> GetAll();
    Student? GetById(Guid id);
    void Add(Student student);
    void Update(Student student);
    void Delete(Guid id);
}

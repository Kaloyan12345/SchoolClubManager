using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public interface IMentorRepository
{
    List<Mentor> GetAll();
    Mentor? GetById(Guid id);
    void Add(Mentor mentor);
    void Update(Mentor mentor);
    void Delete(Guid id);
}
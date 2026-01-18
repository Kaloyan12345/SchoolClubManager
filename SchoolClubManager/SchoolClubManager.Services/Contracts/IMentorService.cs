using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Services.Contracts;

public interface IMentorService
{
    IReadOnlyList<Mentor> GetAll();
    Mentor? GetById(Guid id);
    Mentor Create(Mentor mentor);
    void Update(Mentor mentor);
    void Delete(Guid id);
}

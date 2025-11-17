using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public interface IProjectRepository
{
    List<ClubProject> GetAll();
    ClubProject? GetById(Guid id);
    void Add(ClubProject project);
    void Update(ClubProject project);
    void Delete(Guid id);
}


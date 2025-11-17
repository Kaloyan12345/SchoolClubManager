using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Services.Contracts;

public interface IProjectService
{
    IReadOnlyList<ClubProject> GetAll();
    ClubProject Create(ClubProject project);
    void Update(ClubProject project);
    void Delete(Guid id);
}


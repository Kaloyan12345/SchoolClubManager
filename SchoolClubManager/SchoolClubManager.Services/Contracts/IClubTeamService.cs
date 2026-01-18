using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Services.Contracts;

public interface IClubTeamService
{
    IReadOnlyList<ClubTeam> GetAll();
    ClubTeam? GetById(Guid id);
    ClubTeam Create(ClubTeam team);
    void Update(ClubTeam team);
    void Delete(Guid id);
}

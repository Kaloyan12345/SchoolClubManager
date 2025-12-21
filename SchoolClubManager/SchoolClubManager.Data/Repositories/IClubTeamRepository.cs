using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public interface IClubTeamRepository
{
    List<ClubTeam> GetAll();
    ClubTeam? GetById(Guid id);
    void Add(ClubTeam team);
    void Update(ClubTeam team);
    void Delete(Guid id);
}

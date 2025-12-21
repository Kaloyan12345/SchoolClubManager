using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public interface ITaskItemRepository
{
    List<TaskItem> GetAll();
    TaskItem? GetById(Guid id);
    void Add(TaskItem task);
    void Update(TaskItem task);
    void Delete(Guid id);
}

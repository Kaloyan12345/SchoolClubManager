using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Services.Contracts;

public interface ITaskItemService
{
    IReadOnlyList<TaskItem> GetAll();
    TaskItem? GetById(Guid id);
    TaskItem Create(TaskItem task);
    void Update(TaskItem task);
    void Delete(Guid id);
}

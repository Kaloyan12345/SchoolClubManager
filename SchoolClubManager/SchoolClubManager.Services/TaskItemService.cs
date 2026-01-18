using SchoolClubManager.Business.Models;
using SchoolClubManager.Data.Repositories;
using SchoolClubManager.Services.Contracts;

namespace SchoolClubManager.Services;

public class TaskItemService : ITaskItemService
{
    private readonly ITaskItemRepository _repository;

    public TaskItemService(ITaskItemRepository repository) => _repository = repository;

    public IReadOnlyList<TaskItem> GetAll() => _repository.GetAll();
    public TaskItem? GetById(Guid id) => _repository.GetById(id);

    public TaskItem Create(TaskItem task)
    {
        if (task.Id == Guid.Empty) task.Id = Guid.NewGuid();
        Normalize(task);
        _repository.Add(task);
        return task;
    }

    public void Update(TaskItem task)
    {
        Normalize(task);
        _repository.Update(task);
    }

    public void Delete(Guid id) => _repository.Delete(id);

    private static void Normalize(TaskItem t)
    {
        t.Description = (t.Description ?? string.Empty).Trim();
        if (t.EstimatedHours < 0) t.EstimatedHours = 0;
    }
}

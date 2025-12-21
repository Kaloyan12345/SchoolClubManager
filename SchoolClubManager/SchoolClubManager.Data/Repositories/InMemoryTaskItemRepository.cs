using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public class InMemoryTaskItemRepository : ITaskItemRepository
{
    private readonly List<TaskItem> _tasks = new();

    public List<TaskItem> GetAll() => _tasks
        .OrderBy(t => t.IsCompleted) // unfinished first
        .ThenBy(t => t.Description, StringComparer.CurrentCultureIgnoreCase)
        .ToList();

    public TaskItem? GetById(Guid id) => _tasks.FirstOrDefault(t => t.Id == id);

    public void Add(TaskItem task)
    {
        if (_tasks.Any(t => t.Id == task.Id))
        {
            task.Id = Guid.NewGuid();
        }

        _tasks.Add(task);
    }

    public void Update(TaskItem task)
    {
        var index = _tasks.FindIndex(t => t.Id == task.Id);
        if (index == -1)
        {
            return;
        }

        _tasks[index] = task;
    }

    public void Delete(Guid id)
    {
        var existing = _tasks.FirstOrDefault(t => t.Id == id);
        if (existing is not null)
        {
            _tasks.Remove(existing);
        }
    }
}

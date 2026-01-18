using SchoolClubManager.Business.Models;
using SchoolClubManager.Data.Repositories;
using SchoolClubManager.Services.Contracts;

namespace SchoolClubManager.Services;

public class MentorService : IMentorService
{
    private readonly IMentorRepository _repository;

    public MentorService(IMentorRepository repository) => _repository = repository;

    public IReadOnlyList<Mentor> GetAll() => _repository.GetAll();
    public Mentor? GetById(Guid id) => _repository.GetById(id);

    public Mentor Create(Mentor mentor)
    {
        if (mentor.Id == Guid.Empty) mentor.Id = Guid.NewGuid();
        Normalize(mentor);
        _repository.Add(mentor);
        return mentor;
    }

    public void Update(Mentor mentor)
    {
        Normalize(mentor);
        _repository.Update(mentor);
    }

    public void Delete(Guid id) => _repository.Delete(id);

    private static void Normalize(Mentor m)
    {
        m.FullName = (m.FullName ?? string.Empty).Trim();
        m.Role = (m.Role ?? string.Empty).Trim();
        m.Email = (m.Email ?? string.Empty).Trim();
    }
}

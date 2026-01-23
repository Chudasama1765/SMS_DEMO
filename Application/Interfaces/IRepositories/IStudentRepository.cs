using CampusOne.Domain.Entitys.Student;

namespace Application.Interfaces.IRepositories
{
    public interface IStudentRepository
    {
        Task<List<StudentEntity>> GetAllasync();

        StudentEntity GetById(Guid id);
    }
}

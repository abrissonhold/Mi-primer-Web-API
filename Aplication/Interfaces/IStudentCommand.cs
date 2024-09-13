using Domain.Entities;

namespace Aplication.Interfaces
{
    public interface IStudentCommand
    {
        Task InsertStudent(Student student);
        Task DeleteStudent(int studentId);
    }
}
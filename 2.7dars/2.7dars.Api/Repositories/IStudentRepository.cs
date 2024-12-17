using _2._7dars.Api.DataAccess.Entities;

namespace _2._7dars.Api.Repositories;

public interface IStudentRepository
{
    Guid WriteStudent(Student student);
    List<Student> ReadAllStudents();
    void RemoveStudent(Guid studentId);
    Student GetStudentById(Guid studentId);
    void UpdateStudent(Student student);
    void EmailContains(string email);
}
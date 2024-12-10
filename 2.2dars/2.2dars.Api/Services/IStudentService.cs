using _2._2dars.Api.Models;

namespace _2._2dars.Api.Services;

public interface IStudentService
{
    public Student AddStudent(Student student);
    public Student GetById(Guid studentId);
    public bool DeleteStudent(Guid studentId);
    public bool UpdateStudent(Student student);
    public List<Student> GetAllStudents();
}
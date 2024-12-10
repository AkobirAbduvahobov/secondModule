using _2._2dars.Api.Models;
using System.Text.Json;

namespace _2._2dars.Api.Services;

public class StudentService : IStudentService
{
    private string studentFilePath;
    private List<Student> _students;

    public StudentService()
    {
        studentFilePath = "../../../Data/Students.json";

        if(File.Exists(studentFilePath) is false)
        {
            File.WriteAllText(studentFilePath, "[]");
        }

        _students = new List<Student>();
        _students = GetAllStudents();
    }

    public Student AddStudent(Student student)
    {
        student.Id = Guid.NewGuid();
        _students.Add(student);
        SaveData();
        return student;
    }

    public Student GetById(Guid studentId)
    {
        foreach (var student in _students)
        {
            if (student.Id == studentId)
            {
                return student;
            }
        }

        return null;
    }

    public bool DeleteStudent(Guid studentId)
    {
        var studentFromDb = GetById(studentId);
        if(studentFromDb is null)
        {
            return false;
        }

        _students.Remove(studentFromDb);
        SaveData();
        return true;
    }

    public bool UpdateStudent(Student student)
    {
        var studentFromDb = GetById(student.Id);
        if (studentFromDb is null)
        {
            return false;
        }

        var index = _students.IndexOf(studentFromDb);
        _students[index] = student;
        SaveData();
        return true;
    }

    public List<Student> GetAllStudents()
    {
        return GetStudents();
    }

    private void SaveData()
    {
        var studentsJson = JsonSerializer.Serialize(_students);
        File.WriteAllText(studentFilePath, studentsJson);
    }

    private List<Student> GetStudents()
    {
        var studentsJson = File.ReadAllText(studentFilePath);
        var students = JsonSerializer.Deserialize<List<Student>>(studentsJson);
        return students;
    }
}

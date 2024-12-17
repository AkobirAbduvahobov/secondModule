using _2._7dars.Api.DataAccess.Entities;
using System.Text.Json;

namespace _2._7dars.Api.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly string _path;
    private List<Student> _students;

    public StudentRepository()
    {
        _path = "../../../DataAccess/Data/Students.json";
        _students = new List<Student>();

        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }

        _students = ReadAllStudents();
    }

    public void EmailContains(string email)
    {
        foreach (var student in _students)
        {
            if (student.Email == email)
            {
                throw new Exception("Bunday email bor qo'sha olmaysiz");
            }
        }
    }

    public Student GetStudentById(Guid studentId)
    {
        foreach (var student in _students)
        {
            if (student.Id == studentId)
            {
                return student;
            }
        }

        throw new Exception($"Bunday id : {studentId} li talaba yo'q");
    }

    public List<Student> ReadAllStudents()
    {
        var studentsJson = File.ReadAllText(_path);
        var students = JsonSerializer.Deserialize<List<Student>>(studentsJson);
        return students;
    }

    public void RemoveStudent(Guid studentId)
    {
        var student = GetStudentById(studentId);
        _students.Remove(student);
        SaveData();
    }

    public void UpdateStudent(Student student)
    {
        var updatingStudent = GetStudentById(student.Id);
        var index = _students.IndexOf(updatingStudent);
        _students[index] = student;
        SaveData();
    }

    public Guid WriteStudent(Student student)
    {
        _students.Add(student);
        SaveData();
        return student.Id;
    }

    private void SaveData()
    {
        var studentsJson = JsonSerializer.Serialize(_students);
        File.WriteAllText(_path, studentsJson);
    }
}

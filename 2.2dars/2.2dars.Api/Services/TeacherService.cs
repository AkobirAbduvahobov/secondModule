using _2._2dars.Api.Models;
using System.Text.Json;

namespace _2._2dars.Api.Services;

public class TeacherService : ITeacherService
{
    private string teacherFilePath;
    private List<Teacher> _teachers;

    public TeacherService()
    {
        teacherFilePath = "../../../Data/Teachers.json";

        if (File.Exists(teacherFilePath) is false)
        {
            File.WriteAllText(teacherFilePath, "[]");
        }

        _teachers = new List<Teacher>();
        _teachers = GetAllTeachers();
    }

    public Teacher AddTeacher(Teacher teacher)
    {
        teacher.Id = Guid.NewGuid();
        _teachers.Add(teacher);
        SaveData();
        return teacher;
    }

    public Teacher GetById(Guid teacherId)
    {
        foreach (var teacher in _teachers)
        {
            if (teacher.Id == teacherId)
            {
                return teacher;
            }
        }

        return null;
    }

    public bool DeleteTeacher(Guid teacherId)
    {
        var teacherFromDb = GetById(teacherId);
        if (teacherFromDb is null)
        {
            return false;
        }

        _teachers.Remove(teacherFromDb);
        SaveData();
        return true;
    }

    public bool UpdateTeacher(Teacher teacher)
    {
        var teacherFromDb = GetById(teacher.Id);
        if (teacherFromDb is null)
        {
            return false;
        }

        var index = _teachers.IndexOf(teacherFromDb);
        _teachers[index] = teacher;
        SaveData();
        return true;
    }

    public List<Teacher> GetAllTeachers()
    {
        return GetTeachers();
    }

    private void SaveData()
    {
        var teachersJson = JsonSerializer.Serialize(_teachers);
        File.WriteAllText(teacherFilePath, teachersJson);
    }

    private List<Teacher> GetTeachers()
    {
        var teachersJson = File.ReadAllText(teacherFilePath);
        var teachers = JsonSerializer.Deserialize<List<Teacher>>(teachersJson);
        return teachers;
    }
}

using _2._7dars.Api.DataAccess.Entities;
using _2._7dars.Api.Repositories;
using _2._7dars.Api.Services.DTOs;
using _2._7dars.Api.Services.Enums;

namespace _2._7dars.Api.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    public StudentService()
    {
        _studentRepository = new StudentRepository();
    }

    public Guid AddStudent(StudentCreateDto studentCreateDto)
    {
        var res = ValidateStudentCreateDto(studentCreateDto);
        if (res == false)
        {
            throw new Exception("Hatolik yuz berdi adding while");
        }

        var entity = ConverToEntity(studentCreateDto);
        var id = _studentRepository.WriteStudent(entity);
        return id;
    }

    public void DeleteStudent(Guid studentId)
    {
        _studentRepository.RemoveStudent(studentId);
    }

    public StudentGetDto GetStudentById(Guid studentId)
    {
        var entity = _studentRepository.GetStudentById(studentId);
        var dto = ConvertToDto(entity);
        return dto;
    }

    public List<StudentGetDto> GetStudents()
    {
        var students = _studentRepository.ReadAllStudents();
        //var res = students.Select(st => ConvertToDto(st)).ToList();

        var studentsDto = new List<StudentGetDto>();
        foreach (var student in students)
        {
            studentsDto.Add(ConvertToDto(student));
        }

        return studentsDto; 
    }

    public List<StudentGetDto> GetStudentsByDegree(DegreeStatusDto degreeStatusDto)
    {
        var students = _studentRepository.ReadAllStudents();

        var studentsDto = new List<StudentGetDto>();
        foreach (var student in students)
        {
            if((DegreeStatusDto)student.Degree == degreeStatusDto)
            {
                studentsDto.Add(ConvertToDto(student));
            }
        }

        return studentsDto;
    }

    public List<StudentGetDto> GetStudentsByGender(GenderDto genderDto)
    {
        var students = _studentRepository.ReadAllStudents();

        var studentsDto = new List<StudentGetDto>();
        foreach (var student in students)
        {
            if ((GenderDto)student.Gender == genderDto)
            {
                studentsDto.Add(ConvertToDto(student));
            }
        }

        return studentsDto;
    }

    public void UpdateStudent(StudentUpdateDto studentUpdateDto)
    {
        var entity = ConverToEntity(studentUpdateDto);
        _studentRepository.UpdateStudent(entity);
    }

    private Student ConverToEntity(StudentCreateDto studentCreateDto)
    {
        return new Student
        {
            Id = Guid.NewGuid(),
            FirstName = studentCreateDto.FirstName,
            LastName = studentCreateDto.LastName,
            Age = studentCreateDto.Age,
            Password = studentCreateDto.Password,
            Email = studentCreateDto.Email,
            Gender = (DataAccess.Enums.Gender)studentCreateDto.Gender,
            Degree = (DataAccess.Enums.DegreeStatus)studentCreateDto.Degree,
        };
    }

    private Student ConverToEntity(StudentUpdateDto studentUpdateDto)
    {
        return new Student
        {
            Id = studentUpdateDto.Id,
            FirstName = studentUpdateDto.FirstName,
            LastName = studentUpdateDto.LastName,
            Age = studentUpdateDto.Age,
            Password = studentUpdateDto.Password,
            Email = studentUpdateDto.Email,
            Gender = (DataAccess.Enums.Gender)studentUpdateDto.Gender,
            Degree = (DataAccess.Enums.DegreeStatus)studentUpdateDto.Degree,
        };
    }

    private StudentGetDto ConvertToDto(Student student)
    {
        return new StudentGetDto
        {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Age = student.Age,
            Email = student.Email,
            Degree = (DegreeStatusDto)student.Degree,
            Gender = (GenderDto)student.Gender,
        };
    }

    private bool ValidateStudentCreateDto(StudentCreateDto obj)
    {
        _studentRepository.EmailContains(obj.Email);

        if (string.IsNullOrWhiteSpace(obj.FirstName) || obj.FirstName.Length > 50)
        {
            return false;
        }

        if(string.IsNullOrWhiteSpace(obj.LastName) || obj.LastName.Length > 50)
        {
            return false;
        }

        if(obj.Age < 15 || obj.Age > 150)
        {
            return false;
        }

        if(string.IsNullOrWhiteSpace(obj.Email) || !obj.Email.EndsWith("@gmail.com")
            || obj.Email.Length > 100 || obj.Email.Length <= 10)
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(obj.Password) || obj.Password.Length > 50 || obj.Password.Length < 8)
        {
            return false;
        }

        return  true;   
    }
}

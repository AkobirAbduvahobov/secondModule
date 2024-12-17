using _2._7dars.Api.Services;
using _2._7dars.Api.Services.DTOs;

namespace _2._7dars.Api;

internal class Program
{
    static void Main(string[] args)
    {
        var dto1 = new StudentUpdateDto()
        {
            Id = new Guid("84049652-8d07-4a17-b02d-95eda5c493a2"),
            FirstName = "Aziz",
            LastName = "Botiriov",
            Age = 19,
            Email = "Botirov@gmail.com",
            Password = "password",
            Gender = 0,
            Degree = 0,
        };

        var dto2 = new StudentUpdateDto()
        {
            Id = new Guid("84049652-8d07-4a17-b02d-95eda5c493a1"),
            FirstName = "Azizjon",
            LastName = "Laripov",
            Age = 24,
            Email = "Latipov@gmail.com",
            Password = "password12",
            Gender = 0,
            Degree = (Services.Enums.DegreeStatusDto)1,
        };

        IStudentService studentService = new StudentService();
        studentService.UpdateStudent(dto1);
        studentService.UpdateStudent(dto2);
    }
}


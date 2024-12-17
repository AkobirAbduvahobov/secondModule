using _2._7dars.Api.Services.DTOs;
using _2._7dars.Api.Services.Enums;

namespace _2._7dars.Api.Services;

public interface IStudentService
{
    Guid AddStudent(StudentCreateDto studentCreateDto);
    void DeleteStudent(Guid studentId);
    StudentGetDto GetStudentById(Guid studentId);
    List<StudentGetDto> GetStudents();
    void UpdateStudent(StudentUpdateDto studentUpdateDto);
    List<StudentGetDto> GetStudentsByDegree(DegreeStatusDto degreeStatusDto);
    List<StudentGetDto> GetStudentsByGender(GenderDto genderDto);
}
namespace _2._7dars.Api.Services.DTOs;

public class StudentUpdateDto : BaseStudentDto
{
    public Guid Id { get; set; }
    public string Password { get; set; }
}

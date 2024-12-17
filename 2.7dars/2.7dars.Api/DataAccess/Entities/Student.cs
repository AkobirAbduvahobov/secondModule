using _2._7dars.Api.DataAccess.Enums;

namespace _2._7dars.Api.DataAccess.Entities;

public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Gender Gender { get; set; }
    public DegreeStatus Degree { get; set; }
}

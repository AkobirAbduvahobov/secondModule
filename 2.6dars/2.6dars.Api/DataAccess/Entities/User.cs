namespace _2._6dars.Api.DataAccess.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}

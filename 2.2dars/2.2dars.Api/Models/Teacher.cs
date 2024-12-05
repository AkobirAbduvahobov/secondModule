namespace _2._2dars.Api.Models;

public class Teacher
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string Subject { get; set; }

    public int Likes { get; set; }

    public int DisLikes { get; set; }

    public string Gender { get; set; }
}

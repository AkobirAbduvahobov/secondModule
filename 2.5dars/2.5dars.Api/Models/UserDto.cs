using _2._5dars.Api.Enums;

namespace _2._5dars.Api.Models;

public class UserDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public UserStatus Status { get; set; }
    public UserGender Gender { get; set; }
}

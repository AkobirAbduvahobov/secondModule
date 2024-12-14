using _2._6dars.Api.Services.DTOs;

namespace _2._6dars.Api.Services;

public interface IUserService
{
    UserGetDto AddUser(UserCreateDto dto);
    bool DeleteUser(Guid id);
    bool UpdateUser(UserUpdateDto userUpdateDto);
    List<UserGetDto> GetUsers();    
}
using _2._6dars.Api.DataAccess.Entities;
using _2._6dars.Api.Repositories;
using _2._6dars.Api.Services.DTOs;

namespace _2._6dars.Api.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService()
    {
        _userRepository = new UserRepository();
    }

    public UserGetDto AddUser(UserCreateDto dto)
    {
        var checkingEmail = _userRepository.CheckEmailContains(dto.Email);
        if (!dto.Email.EndsWith("@gmail.com") || checkingEmail)
        {
            return null;
        }

        var user = ConvertToUserEntity(dto);
        var userFromDb = _userRepository.WriteUser(user);
        var userDto = ConvertToDto(userFromDb);
        return userDto;
    }

    public bool DeleteUser(Guid id)
    {
        var res = _userRepository.RemoveUser(id);
        return res;
    }

    public List<UserGetDto> GetUsers()
    {
        var users = _userRepository.ReadUsers();
        var usersGetDto = new List<UserGetDto>();   
        foreach(var user in users)
        {
            usersGetDto.Add(ConvertToDto(user));
        }

        return usersGetDto;
    }

    public bool UpdateUser(UserUpdateDto userUpdateDto)
    {
        var user = ConvertToUserEntity(userUpdateDto);
        var res = _userRepository.UpdateUser(user);

        return res;
    }


    private User ConvertToUserEntity(UserCreateDto dto)
    {
        var user = new User()
        {
            Id = Guid.NewGuid(),
            Email = dto.Email,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Age = dto.Age,
            Password = dto.Password,
        };

        return user;    
    }

    private User ConvertToUserEntity(UserUpdateDto dto)
    {
        var user = new User()
        {
            Id = dto.Id,
            Email = dto.Email,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Age = dto.Age,
            Password = dto.Password,
        };

        return user;    
    }

    private UserGetDto ConvertToDto(User user)
    {
        var dto = new UserGetDto()
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Age = user.Age,
            Email = user.Email,
        };

        return dto;
    }
}

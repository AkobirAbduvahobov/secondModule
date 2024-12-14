using _2._6dars.Api.DataAccess.Entities;

namespace _2._6dars.Api.Repositories;

public interface IUserRepository
{
    User WriteUser(User user);
    bool RemoveUser(Guid id); 
    bool UpdateUser(User user);
    User ReadUserById(Guid id);
    List<User> ReadUsers();
    bool CheckEmailContains(string email);
}
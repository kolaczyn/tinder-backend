using Tinder.Domain.Model;

namespace Tinder.Domain.Repositories;

public interface IUsersRepository
{
  Task<int> AddUser(User user);
  Task<string> AddUserV2(User user);
  Task<User> GetUserById(int id);
  Task<IEnumerable<User>> GetUsers();
}
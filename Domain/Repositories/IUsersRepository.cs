using Kolaczyn.Domain.Model;

namespace Kolaczyn.Domain.Repositories;

public interface IUsersRepository
{
  Task<int> AddUser(User user);
  Task<User> GetUserById(int id);
  Task<IEnumerable<User>> GetUsers();
}
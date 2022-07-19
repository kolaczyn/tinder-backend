using Kolaczyn.Domain.Model;

namespace Kolaczyn.Domain.Repositories;

public interface IUsersRepository
{
  Task AddUser(int id);
  Task<User> GetUserById(int id);
  Task<IEnumerable<User>> GetUsers();
}
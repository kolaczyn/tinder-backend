using Kolaczyn.Domain.Model;

namespace Kolaczyn.Domain.Repositories;

public interface IUsersRepository
{
  void AddUser(int id);
  User GetUserById(int id);
  IEnumerable<User> GetUsers();
}
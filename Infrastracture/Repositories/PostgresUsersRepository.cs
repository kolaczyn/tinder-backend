using Dapper;
using Kolaczyn.Domain.Model;
using Kolaczyn.Domain.Repositories;

namespace Kolaczyn.Infrastructure.Repositories;

public class PosgresUsersRepository : IUsersRepository
{
  public void AddUser(int id)
  {
    throw new NotImplementedException();
  }

  public User GetUserById(int id)
  {
    throw new NotImplementedException();
  }

  public IEnumerable<User> GetUsers()
  {
    throw new NotImplementedException();
  }
}
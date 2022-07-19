using Dapper;
using Kolaczyn.Domain.Model;
using Kolaczyn.Domain.Repositories;

namespace Kolaczyn.Infrastructure.Repositories;

public class PosgresUsersRepository : IUsersRepository
{
  public Task<int> AddUser(User user)
  {
    throw new NotImplementedException();
  }

  public Task<User> GetUserById(int id)
  {
    throw new NotImplementedException();
  }

  public Task<IEnumerable<User>> GetUsers()
  {
    throw new NotImplementedException();
  }
}
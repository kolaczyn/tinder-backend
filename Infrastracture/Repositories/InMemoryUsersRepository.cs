using Kolaczyn.Domain.Model;
using Kolaczyn.Domain.Repositories;

namespace Kolaczyn.Infrastructure.Repositories;

public class InMemoryUsersRepository : IUsersRepository
{
  static Dictionary<int, User> db = new();

  public async Task AddUser(int id)
  {
    var user = new User { Name = "Pawel", Age = 23 };
    db.Add(id, user);
    return;
  }

  // TODO Maybe
  public async Task<User> GetUserById(int id)
  {
    return db[id];
  }

  public async Task<IEnumerable<User>> GetUsers()
  {
    List<User> output = new(10);
    foreach (KeyValuePair<int, User> entry in db)
    {
      output.Add(entry.Value);
    }
    return output;
  }
}
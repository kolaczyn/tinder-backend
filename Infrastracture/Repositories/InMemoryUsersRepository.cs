using Kolaczyn.Domain.Model;
using Kolaczyn.Domain.Repositories;

namespace Kolaczyn.Infrastructure.Repositories;

public class InMemoryUsersRepository : IUsersRepository
{
  static Dictionary<int, User> db = new();
  static int NextId = 0;

  public Task<int> AddUser(User user)
  {
    int id = NextId;
    db.Add(id, user);
    NextId++;
    return Task.FromResult(id);
  }

  // TODO Maybe
  public Task<User> GetUserById(int id)
  {
    return Task.FromResult(db[id]);
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
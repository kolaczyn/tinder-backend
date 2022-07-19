using Kolaczyn.Domain.Model;
using Kolaczyn.Domain.Repositories;

namespace Kolaczyn.Infrastructure.Repositories;

public class InMemoryUsersRepository : IUsersRepository
{
  static Dictionary<int, User> db = new();

  public void AddUser(int id)
  {
    var user = new User { Name = "Pawel", Age = 23 };
    db.Add(id, user);
  }

  // TODO Maybe
  public User GetUserById(int id)
  {
    return db[id];
  }

  public IEnumerable<User> GetUsers()
  {
    List<User> output = new(10);
    foreach (KeyValuePair<int, User> entry in db)
    {
      output.Add(entry.Value);
    }
    return output;
  }
}
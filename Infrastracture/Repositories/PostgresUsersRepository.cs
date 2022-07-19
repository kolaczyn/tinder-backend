using Dapper;
using Kolaczyn.Domain.Model;
using Kolaczyn.Domain.Repositories;
using Npgsql;

namespace Kolaczyn.Infrastructure.Repositories;

public class PosgresUsersRepository : IUsersRepository
{
  public async Task<int> AddUser(User user)
  {
    await using (var connection = new NpgsqlConnection("Host=db;Username=postgres;Password=postgres;Database=postgres;Port=5432"))
    {
      // TODO creat class UserDb in Repo folder.
      // and make sure this is the way to do this
      var result = await connection.ExecuteAsync("INSERT INTO users (name, age) VALUES (@name, @age)", new { user.Name, user.Age });
      return result;
      ;
    }
  }


  public async Task<User> GetUserById(int id)
  {
    await using (var connection = new NpgsqlConnection("Host=db;Username=postgres;Password=postgres;Database=postgres;Port=5432"))
    {
      var result = await connection.QueryAsync<User>("SELECT name, age FROM users WHERE id = @id", new { Id = id });
      return result.FirstOrDefault();
    }
  }

  public async Task<IEnumerable<User>> GetUsers()
  {
    await using (var connection = new NpgsqlConnection("Host=db;Username=postgres;Password=postgres;Database=postgres;Port=5432"))
    {
      var result = await connection.QueryAsync<User>("SELECT name, age FROM users");
      return result.AsList();
    }
  }
}
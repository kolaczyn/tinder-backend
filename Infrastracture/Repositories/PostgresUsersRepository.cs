using Dapper;
using Kolaczyn.Domain.Model;
using Kolaczyn.Domain.Repositories;
using Npgsql;

namespace Kolaczyn.Infrastructure.Repositories;

public class PosgresUsersRepository : IUsersRepository
{
  NpgsqlConnection _connection;
  public async Task<int> AddUser(User user)
  {
    await using (var connection = new NpgsqlConnection("Host=db;Username=postgres;Password=postgres;Database=postgres;Port=5432"))
    {
      await using (var cmd = new NpgsqlCommand("SELECT name, age FROM users", connection))
      {
        // TODO creat class UserDb in Repo folder.
        // and make sure this is the way to do this
        var result = await connection.ExecuteAsync("INSERT INTO users (name, age) VALUES (@name, @age)", new { user.Name, user.Age, Id = 29 });
        return result;
      };
    }
  }


  public async Task<User> GetUserById(int id)
  {
    await using (var connection = new NpgsqlConnection("Host=db;Username=postgres;Password=postgres;Database=postgres;Port=5432"))
    {
      await using (var cmd = new NpgsqlCommand("SELECT name, age FROM users", connection))
      {
        // TODO creat class UserDb in Repo folder.
        // and make sure this is the way to do this
        var result = await connection.QueryAsync<User>("SELECT name, age FROM users WHERE id = @id", new { Id = id });
        return result.FirstOrDefault();
      };
    }
  }

  public async Task<IEnumerable<User>> GetUsers()
  {
    await using (var connection = new NpgsqlConnection("Host=db;Username=postgres;Password=postgres;Database=postgres;Port=5432"))
    {
      await using (var cmd = new NpgsqlCommand("SELECT name, age FROM users", connection))
      {
        // TODO creat class UserDb in Repo folder.
        // and make sure this is the way to do this
        var result = await connection.QueryAsync<User>("SELECT name, age FROM users");
        return result.AsList();
      };
    }
  }
}
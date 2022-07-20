using Microsoft.Extensions.Options;
using Npgsql;
using Dapper;
using Kolaczyn.Domain.Model;
using Kolaczyn.Domain.Repositories;
using Kolaczyn.Infrastructure.Model;
using Kolaczyn.Infrastructure.Settings;
using Kolaczyn.Infrastructure.Mappers;

namespace Kolaczyn.Infrastructure.Repositories;

public class PosgresUsersRepository : IUsersRepository
{
  private readonly AppSettings _appSettings;

  public PosgresUsersRepository(IOptions<AppSettings> appSettings)
  {
    _appSettings = appSettings.Value;
  }

  public async Task<int> AddUser(User user)
  {
    await using (var connection = new NpgsqlConnection(_appSettings.PostgresConnectionString))
    {
      var result = await connection.ExecuteAsync("INSERT INTO users (name, age) VALUES (@name, @age)", new { user.Name, user.Age });
      return result;
      ;
    }
  }

  public async Task<string> AddUserV2(User user)
  {
    await using (var connection = new NpgsqlConnection(_appSettings.PostgresConnectionString))
    {
      var result = await connection.ExecuteAsync("INSERT INTO users (name, age) VALUES (@name, @age)", new { user.Name, user.Age });
      // TODO get the correct id
      var id = 123;
      // TODO fix the url later
      return $"http://127.0.0.1:5294/Match/{id}'";
      ;
    }
  }

  public async Task<User> GetUserById(int id)
  {
    await using (var connection = new NpgsqlConnection(_appSettings.PostgresConnectionString))
    {
      var result = await connection.QueryAsync<DbUser>("SELECT name, age FROM users WHERE id = @id", new { Id = id });
      return result.FirstOrDefault().ToDomain();
    }
  }

  public async Task<IEnumerable<User>> GetUsers()
  {
    await using (var connection = new NpgsqlConnection(_appSettings.PostgresConnectionString))
    {
      var result = await connection.QueryAsync<DbUser>("SELECT name, age FROM users");
      return result.AsList().Select(x => x.ToDomain());
    }
  }
}
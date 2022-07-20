using Microsoft.Extensions.Options;
using Npgsql;
using Dapper;
using Tinder.Domain.Model;
using Tinder.Domain.Repositories;
using Tinder.Infrastructure.Model;
using Tinder.Infrastructure.Settings;
using Tinder.Infrastructure.Mappers;

namespace Tinder.Infrastructure.Repositories;

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
      var id = await connection.QueryAsync<int>("INSERT INTO users (name, age) VALUES (@name, @age) RETURNING id", new { user.Name, user.Age });
      return $"{_appSettings.BaseUrl}/Match/{id.First()}'";
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
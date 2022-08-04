using Cocona;
using Npgsql;

var app = CoconaApp.Create();

app.AddCommand("init-db", async () =>
{
  await using var connection = new NpgsqlConnection("Host=db;Username=postgres;Password=postgres;Database=postgres;Port=5432");
  await connection.OpenAsync();
  await using (var cmd = new NpgsqlCommand(@"
    CREATE TABLE users (
      id SERIAL PRIMARY KEY,
      name TEXT NOT NULL,
      gender INT NOT NULL,
      age INT NOT NULL)
    ", connection))
  {
    await cmd.ExecuteReaderAsync();
  };
  connection.Close();
}).WithDescription("Initialize the database").WithAliases("i");

app.AddCommand("kill-db", async () =>
{
  await using var connection = new NpgsqlConnection("Host=db;Username=postgres;Password=postgres;Database=postgres;Port=5432");
  await connection.OpenAsync();
  await using (var cmd = new NpgsqlCommand("DROP TABLE users", connection))
  {
    await cmd.ExecuteReaderAsync();
  };
  connection.Close();
}).WithDescription("Kill the database").WithAliases("k");

app.Run();

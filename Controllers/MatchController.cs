using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Dapper;
using Kolaczyn.Application.UseCases;
using Kolaczyn.Domain.Model;
using Kolaczyn.Application.Dto;

namespace Kolaczyn.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
  [HttpPost]
  public async Task<ActionResult> AddUser(UserDto user, [FromServices] AddUserUseCase useCase)
  {
    try
    {
      int id = await useCase.Execute(user);
      return Ok(id);
    }
    // I should use custom exception.
    // Or use ROP
    catch (Exception e)
    {

      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public async Task<User> GetUser(int id, [FromServices] GetUserUseCase useCase)
  {
    return await useCase.Execute(id);
  }

  [HttpGet]
  public async Task<IEnumerable<User>> GetUsers([FromServices] GetUsersUseCase useCase)
  {
    return await useCase.Execute();
  }

  // TODO this is pretty dumb
  [HttpGet("initDb")]
  public async Task InitDb()
  {

    await using var connection = new NpgsqlConnection("Host=db;Username=postgres;Password=postgres;Database=postgres;Port=5432");
    await connection.OpenAsync();
    await using (var cmd = new NpgsqlCommand("CREATE TABLE users(id INT PRIMARY KEY NOT NULL, name TEXT NOT NULL, age INT NOT NULL)", connection))
    {
      var xd = await cmd.ExecuteReaderAsync();
    };
    connection.Close();

  }

}
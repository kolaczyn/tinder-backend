using Microsoft.AspNetCore.Mvc;
using Kolaczyn.Application.UseCases;
using Kolaczyn.Domain.Model;

namespace Kolaczyn.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
  [HttpPost("{id}")]
  public async Task AddUser(int id, [FromServices] AddUserUseCase useCase)
  {
    await useCase.Execute(id);
    return;
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

}
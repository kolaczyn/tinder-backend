using Microsoft.AspNetCore.Mvc;
using Kolaczyn.Application.UseCases;
using Kolaczyn.Domain.Model;

namespace Kolaczyn.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
  private readonly GetUsersUseCase _getUsersUserCase;
  private readonly GetUserUseCase _getUserUserCase;
  private readonly AddUserUseCase _addUserUseCase;
  public MatchController(GetUsersUseCase getUsersUserCase, AddUserUseCase addUserUseCase, GetUserUseCase getUserUseCase)
  {
    // TODO these should be [FromService]
    _getUsersUserCase = getUsersUserCase;
    _getUserUserCase = getUserUseCase;
    _addUserUseCase = addUserUseCase;
  }

  [HttpPost("{id}")]
  public async Task AddUser(int id)
  {
    // TODO change useCase
    await _addUserUseCase.Execute(id);
    return;
  }

  [HttpGet("{id}")]
  public async Task<User> GetUser(int id)
  {
    // TODO change useCase
    return await _getUserUserCase.Execute(id);
  }

  [HttpGet]
  public async Task<IEnumerable<User>> GetUsers()
  {
    return await _getUsersUserCase.Execute();
  }

}
using Microsoft.AspNetCore.Mvc;
using Kolaczyn.Application.UseCases;
using Kolaczyn.Domain.Model;

namespace Kolaczyn.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
  private readonly GetUsersUseCase _getUsersUserCase;
  public MatchController(GetUsersUseCase getUsersUserCase)
  {
    _getUsersUserCase = getUsersUserCase;
  }

  [HttpPost]
  public async Task<IEnumerable<User>> AddUser()
  {
    // TODO change useCase
    return await _getUsersUserCase.Execute();
  }

  [HttpGet("{id}")]
  public async Task<IEnumerable<User>> GetUser(int id)
  {
    // TODO change useCase
    return await _getUsersUserCase.Execute();
  }

  [HttpGet]
  public async Task<IEnumerable<User>> GetUsers()
  {
    return await _getUsersUserCase.Execute();
  }

}
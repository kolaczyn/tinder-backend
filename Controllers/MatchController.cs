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
  public IEnumerable<User> AddUser()
  {
    // TODO change useCase
    return _getUsersUserCase.Execute();
  }

  [HttpGet("{id}")]
  public IEnumerable<User> GetUser(int id)
  {
    // TODO change useCase
    return _getUsersUserCase.Execute();
  }

  [HttpGet]
  public IEnumerable<User> GetUsers()
  {
    return _getUsersUserCase.Execute();
  }

}
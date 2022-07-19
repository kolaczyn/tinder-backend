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

  [HttpGet(Name = "Match")]
  public IEnumerable<User> Get()
  {
    return _getUsersUserCase.Execute();

  }
}
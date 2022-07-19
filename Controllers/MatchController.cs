using Microsoft.AspNetCore.Mvc;
using Kolaczyn.Application.UseCases;

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
  public int Get()
  {
    return _getUsersUserCase.Execute();

  }
}
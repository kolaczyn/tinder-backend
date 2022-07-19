using Microsoft.AspNetCore.Mvc;
using Kolaczyn.Legacy.Models;
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

  private static readonly User[] PortalUsers = new[]
  {
    new User("Ada", Sex.Female, 25),
    new User("Karolina", Sex.Female, 32),
    new User("Jagoda", Sex.Other, 20),
    new User("Witosz", Sex.Male, 29),
};

  [HttpGet(Name = "Match")]
  public int Get()
  {
    return _getUsersUserCase.Execute();

  }
}
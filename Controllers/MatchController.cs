using Microsoft.AspNetCore.Mvc;
using Kolaczyn.Legacy.Models;
using Kolaczyn.Legacy.Mapper;
using Kolaczyn.Application.UseCases;

namespace Kolaczyn.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
  private readonly GetUsersUseCase _getUsersUserCase;
  // TODO add dependency injection
  public MatchController()
  {
    _getUsersUserCase = new GetUsersUseCase();
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
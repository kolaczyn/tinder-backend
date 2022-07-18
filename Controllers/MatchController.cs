using Microsoft.AspNetCore.Mvc;
using Kolaczyn.Models;
using Kolaczyn.Mapper;

namespace Kolaczyn.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
  private static readonly User[] PortalUsers = new[]
  {
    new User("Ada", Sex.Female, 25),
    new User("Karolina", Sex.Female, 32),
    new User("Jagoda", Sex.Other, 20),
    new User("Witosz", Sex.Male, 29),
};

  [HttpGet(Name = "Match")]
  public UserDto Get()
  {
    return PortalUsers[1].MapToDto();

  }
}
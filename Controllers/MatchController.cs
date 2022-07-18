using Microsoft.AspNetCore.Mvc;
using Kolaczyn.Models;

namespace Kolaczyn.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
  private static readonly User[] PortalUsers = new[]
  {
    new User("Ada", 0, 25),
    new User("Karolina", 0, 32),
    new User("Jagoda", 0, 20),
    new User("Witosz", 1, 29),
};

  [HttpGet(Name = "Match")]
  public User Get()
  {
    return PortalUsers[1];

  }
}
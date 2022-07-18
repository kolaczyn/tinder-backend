using Microsoft.AspNetCore.Mvc;

namespace Kolaczyn.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
  private static readonly string[] LadyNames = new[]
  {
    "Ada", "Karolina", "Jagoda"
};

  [HttpGet(Name = "Match")]
  public IEnumerable<string> Get()
  {
    return LadyNames.ToArray();

  }
}
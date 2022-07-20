using Microsoft.AspNetCore.Mvc;
using Tinder.Application.UseCases;
using Tinder.Domain.Model;
using Tinder.Application.Models;

namespace Tinder.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
  [Obsolete("use v2 instead")]
  [HttpPost]
  public async Task<ActionResult> AddUser(UserDto user, [FromServices] AddUserUseCase useCase)
  {
    try
    {
      int id = await useCase.Execute(user);
      return Ok(id);
    }
    // I should use custom exception.
    // Or use ROP
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost("v2")]
  public async Task<ActionResult<ResourceUrlDto>> AddUserV2(UserDto user, [FromServices] AddUserV2UseCase useCase)
  {
    try
    {
      var resourceUrl = await useCase.Execute(user);
      return Ok(resourceUrl);
    }
    // I should use custom exception.
    // Or use ROP
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public async Task<User> GetUser(int id, [FromServices] GetUserUseCase useCase)
  {
    return await useCase.Execute(id);
  }

  [HttpGet]
  public async Task<IEnumerable<User>> GetUsers([FromServices] GetUsersUseCase useCase)
  {
    return await useCase.Execute();
  }

}
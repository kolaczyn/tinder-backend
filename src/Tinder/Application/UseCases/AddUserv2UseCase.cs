using Kolaczyn.Domain.Repositories;
using Kolaczyn.Domain.Validators;
using Kolaczyn.Application.Mappers;
using Kolaczyn.Application.Models;

namespace Kolaczyn.Application.UseCases;

public class AddUserV2UseCase
{
  private readonly IUsersRepository _usersRepository;
  private readonly UserValidator _userValidator;

  public AddUserV2UseCase(IUsersRepository usersRepository)
  {
    _usersRepository = usersRepository;
    _userValidator = new UserValidator();
  }

  public async Task<ResourceUrlDto> Execute(UserDto user)
  {
    var domain = user.ToDomain();
    var result = _userValidator.Validate(domain);
    if (result.IsValid)
    {
      var url = await this._usersRepository.AddUserV2(domain);
      return new ResourceUrlDto { ResourceUrl = url };
    }
    throw new Exception(result.ToString());
  }
}
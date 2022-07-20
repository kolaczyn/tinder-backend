using Tinder.Domain.Repositories;
using Tinder.Domain.Validators;
using Tinder.Application.Mappers;
using Tinder.Application.Models;

namespace Tinder.Application.UseCases;

public class AddUserUseCase
{
  private readonly IUsersRepository _usersRepository;
  private readonly UserValidator _userValidator;

  public AddUserUseCase(IUsersRepository usersRepository)
  {
    _usersRepository = usersRepository;
    _userValidator = new UserValidator();
  }

  public async Task<int> Execute(UserDto user)
  {
    var domain = user.ToDomain();
    var result = _userValidator.Validate(domain);
    if (result.IsValid)
    {

      var id = await this._usersRepository.AddUser(domain);
      return id;
    }
    throw new Exception(result.ToString());
  }
}
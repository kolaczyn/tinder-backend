using Kolaczyn.Domain.Repositories;
using Kolaczyn.Application.Mappers;
using Kolaczyn.Application.Dto;

namespace Kolaczyn.Application.UseCases;

public class AddUserUseCase
{
  private readonly IUsersRepository _usersRepository;

  public AddUserUseCase(IUsersRepository usersRepository)
  {
    _usersRepository = usersRepository;
  }

  public async Task<int> Execute(UserDto user)
  {
    var domainUser = user.ToDomain();
    var id = await this._usersRepository.AddUser(domainUser);
    return id;
  }
}
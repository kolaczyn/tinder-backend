using Kolaczyn.Domain.Repositories;
using Kolaczyn.Domain.Model;

namespace Kolaczyn.Application.UseCases;

public class AddUserUseCase
{
  private readonly IUsersRepository _usersRepository;

  public AddUserUseCase(IUsersRepository usersRepository)
  {
    _usersRepository = usersRepository;
  }

  public async Task Execute(int id)
  {
    await this._usersRepository.AddUser(id);
    return;
  }
}
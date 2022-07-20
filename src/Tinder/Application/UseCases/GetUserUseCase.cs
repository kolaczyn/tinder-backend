using Kolaczyn.Domain.Repositories;
using Kolaczyn.Domain.Model;

namespace Kolaczyn.Application.UseCases;

public class GetUserUseCase
{
  private readonly IUsersRepository _usersRepository;

  public GetUserUseCase(IUsersRepository usersRepository)
  {
    _usersRepository = usersRepository;
  }

  public async Task<User> Execute(int id)
  {
    return await this._usersRepository.GetUserById(id);
  }
}
using Kolaczyn.Domain.Repositories;
using Kolaczyn.Domain.Model;

namespace Kolaczyn.Application.UseCases;

public class GetUsersUseCase
{
  private readonly IUsersRepository _usersRepository;

  public GetUsersUseCase(IUsersRepository usersRepository)
  {
    _usersRepository = usersRepository;
  }

  public async Task<IEnumerable<User>> Execute()
  {
    return await this._usersRepository.GetUsers();
  }
}
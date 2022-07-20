using Tinder.Domain.Repositories;
using Tinder.Domain.Model;

namespace Tinder.Application.UseCases;

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
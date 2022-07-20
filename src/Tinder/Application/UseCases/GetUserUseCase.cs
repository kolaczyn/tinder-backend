using Tinder.Domain.Repositories;
using Tinder.Domain.Model;

namespace Tinder.Application.UseCases;

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
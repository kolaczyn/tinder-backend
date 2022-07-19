using Kolaczyn.Domain.Repositories;
using Kolaczyn.Infrastructure.Repositories;

namespace Kolaczyn.Application.UseCases;

public class GetUsersUseCase
{
  private readonly IUsersRepository _usersRepository;

  // TODO add dependency injection
  public GetUsersUseCase()
  {
    _usersRepository = new PosgresUsersRepository();
  }

  public int Execute()
  {
    return this._usersRepository.GetTwenty();
  }
}
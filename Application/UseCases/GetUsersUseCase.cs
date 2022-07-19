using Kolaczyn.Domain.Repositories;

namespace Kolaczyn.Application.UseCases;

public class GetUsersUseCase
{
  private readonly IUsersRepository _usersRepository;

  public GetUsersUseCase(IUsersRepository usersRepository)
  {
    _usersRepository = usersRepository;
  }

  public int Execute()
  {
    return this._usersRepository.GetTwenty();
  }
}
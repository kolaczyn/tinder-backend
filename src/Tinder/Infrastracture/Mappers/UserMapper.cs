using Mapster;
using Tinder.Domain.Model;
using Tinder.Infrastructure.Model;

namespace Tinder.Infrastructure.Mappers;

public static class UserMap
{
  public static DbUser ToInfrastructure(this User user)
  {
    return user.Adapt<DbUser>();
  }
  public static User ToDomain(this DbUser user)
  {
    return user.Adapt<User>();
  }
}


using Mapster;
using Kolaczyn.Domain.Model;
using Kolaczyn.Infrastructure.Model;

namespace Kolaczyn.Infrastructure.Mappers;

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


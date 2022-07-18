using Mapster;
using Kolaczyn.Models;

namespace Kolaczyn.Extensions;

public static class UserMapper
{
  public static User ToDomain(this UserDto user)
  {
    return user.Adapt<User>();
  }
  public static UserDto ToDto(this User user)
  {
    return user.Adapt<UserDto>();
  }
}


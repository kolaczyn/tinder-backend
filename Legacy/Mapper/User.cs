using Mapster;
using Kolaczyn.Legacy.Models;

namespace Kolaczyn.Legacy.Mapper;

[Obsolete("Move to clean arch")]
public static class UserMapper
{
  public static User MapToDomain(this UserDto user)
  {
    return user.Adapt<User>();
  }
  public static UserDto MapToDto(this User user)
  {
    return user.Adapt<UserDto>();
  }
}


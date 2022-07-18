using Mapster;
using Kolaczyn.Models;

namespace Kolaczyn.Mapper;

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


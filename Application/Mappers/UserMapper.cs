using Mapster;
using Kolaczyn.Application.Dto;

namespace Kolaczyn.Application.Mappers;

public static class UserMapper
{
  public static Kolaczyn.Domain.Model.User ToDomain(this UserDto dto)
  {
    return dto.Adapt<Kolaczyn.Domain.Model.User>();
  }
  public static UserDto ToDto(this Kolaczyn.Domain.Model.User user)
  {
    return user.Adapt<UserDto>();
  }
}
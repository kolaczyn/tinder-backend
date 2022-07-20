using Mapster;
using Tinder.Application.Models;

namespace Tinder.Application.Mappers;

public static class UserMapper
{
  public static Tinder.Domain.Model.User ToDomain(this UserDto dto)
  {
    return dto.Adapt<Tinder.Domain.Model.User>();
  }
  public static UserDto ToDto(this Tinder.Domain.Model.User user)
  {
    return user.Adapt<UserDto>();
  }
}
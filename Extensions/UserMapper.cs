using Kolaczyn.Models;

namespace Kolaczyn.Extensions;

public static class UserMapper
{
  // should probably use library for this
  public static User ToDomain(this UserDto user)
  {
    Sex sex;
    Enum.TryParse(user.Sex, out sex);
    return new User(user.Name, sex, user.Age);
  }
  public static UserDto ToDto(this User user)
  {
    return new(user.Name, user.Id, user.Sex.ToString(), user.Age);
  }
}


using System.Runtime.Serialization;

namespace Tinder.Domain.Models;

public enum Gender
{
  [EnumMember(Value = "Other")]
  Other = -1,
  [EnumMember(Value = "Female")]
  Female = 0,
  [EnumMember(Value = "Male")]
  Male = 1,
}
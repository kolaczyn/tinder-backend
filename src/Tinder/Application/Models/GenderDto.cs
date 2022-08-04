using System.Runtime.Serialization;

namespace Tinder.Application.Models;

public enum GenderDto {
  [EnumMember(Value = "Other")]
  Other = -1,
  [EnumMember(Value = "Female")]
  Female = 0,
  [EnumMember(Value = "Male")]
  Male = 1,
}
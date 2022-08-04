namespace Tinder.Domain.Model;

public record User
{
  public string? Name { get; set; }
  public int? Age { get; set; }
  public string? Gender { get; set; }
}
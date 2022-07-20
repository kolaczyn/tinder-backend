namespace Kolaczyn.Domain.Model;

public record User
{
  public string? Name { get; set; }
  public int? Age { get; set; }
}
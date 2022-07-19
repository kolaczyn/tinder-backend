namespace Kolaczyn.Domain.Model;

public record User
{
  // FIXME is there a way to make record's fields not nullable?
  public string Name { get; init; }
  public int Age { get; init; }
}
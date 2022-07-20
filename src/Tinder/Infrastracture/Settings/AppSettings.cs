namespace Tinder.Infrastructure.Settings;

public class AppSettings
{
  public const string SectionName = "AppSettings";
  public string PostgresConnectionString { get; set; }
}
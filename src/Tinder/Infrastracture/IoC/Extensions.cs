using Tinder.Domain.Repositories;
using Tinder.Infrastructure.Repositories;
using Tinder.Infrastructure.Settings;

namespace Tinder.Infrastructure.IoC;

public static class Extensions
{
  public static void AddServices(this IServiceCollection services)
  {
    services.AddTransient<IUsersRepository, PostgresUsersRepository>();
    services.AddTransient<AppSettings>();
  }
}
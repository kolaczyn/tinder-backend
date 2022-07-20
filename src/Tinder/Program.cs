using Tinder.Domain.Repositories;
using Tinder.Infrastructure.Repositories;
using Tinder.Application.UseCases;
using Tinder.Infrastructure.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection(AppSettings.SectionName));

builder.Services.AddTransient<IUsersRepository, PosgresUsersRepository>();
builder.Services.AddTransient<GetUsersUseCase>();
builder.Services.AddTransient<GetUserUseCase>();
builder.Services.AddTransient<AddUserUseCase>();
builder.Services.AddTransient<AddUserV2UseCase>();
builder.Services.AddTransient<AppSettings>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

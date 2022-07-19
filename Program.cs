using Kolaczyn.Domain.Repositories;
using Kolaczyn.Infrastructure.Repositories;
using Kolaczyn.Application.UseCases;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUsersRepository, InMemoryUsersRepository>();
builder.Services.AddTransient<GetUsersUseCase>();
builder.Services.AddTransient<GetUserUseCase>();
builder.Services.AddTransient<AddUserUseCase>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
